using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentDB.Model;

namespace EquipmentDB.Controller
{
    /// <summary>
    /// Реализация паттерна Singleton
    /// </summary>
    public class Repository
    {
        private static IRepository _instance;

        public static IRepository Instance
        {
            get { return _instance ?? (_instance = new MsSqlRepository()); }
        }

        protected Repository() { }
    }

    public class MsSqlRepository : IRepository
    {

        /// <summary>
        /// Метод создания резервной копии БД
        /// </summary>
        public void CreateBackup(string bakFilePath)
        {
            using (var context = new EquipmentDBEntities())
            {
                var sqlCommand = $"BACKUP DATABASE EquipmentDB TO DISK='{bakFilePath}EquipmentDB_{DateTime.Now.ToShortDateString()}.bak'";
                context.Database.ExecuteSqlCommand(sqlCommand);
            }
        }


        /// <summary>
        /// Класс для получения данных о файлах резервной версии БД
        /// </summary>
        private class DbFileData
        {
            public string LogicalName { get; set; }
            public string PhysicalName { get; set; }
            public string Type { get; set; }
        }

        public void RestoreDatabase(string bakFilePath)
        {
            using (var context = new EquipmentDBEntities())
            {
                var query = "USE master; " +
                           "ALTER DATABASE EquipmentDB SET Single_User WITH Rollback Immediate; " +
                           $"RESTORE DATABASE EquipmentDB FROM DISK = '{bakFilePath}' WITH REPLACE; " +
                           "ALTER DATABASE EquipmentDB SET Multi_User; ";
                context.Database.ExecuteSqlCommand(query);
            }
        }


        /// <summary>
        /// Ссылка на вошедшего пользователя
        /// </summary>
        private User _currentUser;

        /// <summary>
        /// Метод возвращает объект текущего пользователя системы
        /// </summary>
        public User GetCurrentUser()
        {
            return _currentUser;
        }

        /// <summary>
        /// проверка первого запуска программы
        /// </summary>
        public bool FirstStart()
        {
            using (var context = new EquipmentDBEntities())
            {
                if (!context.BalanceTypes.Any())
                {
                    context.BalanceTypes.Add(new BalanceType() { BalanceTypeName = "Балансный" });
                    context.BalanceTypes.Add(new BalanceType() { BalanceTypeName = "Забалансный" });
                    context.SaveChanges();
                }
                return !context.Users.Any();
            }
        }

        /// <summary>
        /// Метод логина пользователя в системе
        /// Вход по лоигу и паролю
        /// </summary>
        public void UserLogin(string login, string password)
        {
            using (var context = new EquipmentDBEntities())
            {
                context.Employees.Load();
                context.Posts.Load();
                context.Organizations.Load();
                _currentUser = context.Users.FirstOrDefault(user => user.Login == login && password == user.Password);
            }
        }

        #region Методы поиска по параметрам

        public List<WriteOffEquipment> FindWriteOffEquipments(Manufacturer manufacturer, EquipmentType eqType, BalanceType balanceType, string serial,
            string inventory, string equipName, string orderNumber, DateTime? orderDate)
        {
            using (var context = new EquipmentDBEntities())
            {
                context.EquipmentTypes.Load();
                context.Manufacturers.Load();
                context.BalanceTypes.Load();
                context.Equipments.Load();
                var query = context.WriteOffEquipments.AsQueryable();
                if (manufacturer.Manufacturer_ID > 0)
                {
                    query = query.Where(woEquip => woEquip.Equipment.Manufacturer_ID == manufacturer.Manufacturer_ID);
                }
                if (eqType.EquipmentType_ID > 0)
                {
                    query = query.Where(woEquip => woEquip.Equipment.EquipmentType_ID == eqType.EquipmentType_ID);
                }
                if (balanceType.BalanceType_ID > 0)
                {
                    query = query.Where(woEquip => woEquip.Equipment.BalanceType_ID == balanceType.BalanceType_ID);
                }
                if (!string.IsNullOrWhiteSpace(serial))
                {
                    query = query.Where(woEquip => woEquip.Equipment.Serial.Contains(serial));
                }
                if (!string.IsNullOrWhiteSpace(inventory))
                {
                    query = query.Where(woEquip => woEquip.Equipment.InventoryNumber.Contains(inventory));
                }
                if (!string.IsNullOrWhiteSpace(equipName))
                {
                    query = query.Where(woEquip => woEquip.Equipment.EquipmentName.Contains(equipName));
                }
                if (!string.IsNullOrWhiteSpace(orderNumber))
                {
                    query = query.Where(woEquip => woEquip.OrderNumber.Contains(equipName));
                }
                if (orderDate.HasValue)
                {
                    query = query.Where(woEquip => woEquip.OrderDate == orderDate.Value);
                }
                return query.ToList();
            }
        }

        public List<EquipmentLeasing> FindEquipmentLeasings(Employee employeeOut, Employee employeeIn, DateTime? dtEnter,
                                                            DateTime? dtReturn, string inventory, bool isArchiveSearch)
        {
            using (var context = new EquipmentDBEntities())
            {
                context.Posts.Load();
                context.Employees.Load();
                context.Equipments.Load();
                //context.EquipmentTypes.Load();
                //context.Manufacturers.Load();
                var query = context.EquipmentLeasings.Include("EmployeeEquipments").AsQueryable();
                if (employeeOut.Employee_ID > 0)
                {
                    query = query.Where(el => el.Employee.Employee_ID == employeeOut.Employee_ID);
                }
                if (employeeIn.Employee_ID > 0)
                {
                    query = query.Where(el => el.Employee1.Employee_ID == employeeIn.Employee_ID);
                }
                if (dtEnter.HasValue)
                {
                    query = query.Where(el => el.DateOfIssue == dtEnter.Value);
                }
                if (dtReturn.HasValue)
                {
                    query = query.Where(el => el.DateReturn == dtReturn.Value);
                }

                query = query.Where(leasing => leasing.IsArchive == isArchiveSearch);

                if (!string.IsNullOrWhiteSpace(inventory))
                {
                    return query.ToList().Where(eq => eq.EmployeeEquipments.Any(equipment => equipment.InventoryNumber.ToLower().Contains(inventory.ToLower()))).ToList();
                }
                return query.ToList();
            }
        }

        /// <summary>
        /// Метод поиска оборудования в эксплуатации по параметрам
        /// </summary>
        public List<RoomEquipment> FindRoomEquipments(Manufacturer manufacturer, EquipmentType equipmentType,
            BalanceType balanceType, string serial, string inventory, string equipName, Corps corps, Room room)
        {
            using (var context = new EquipmentDBEntities())
            {
                context.EquipmentTypes.Load();
                context.Manufacturers.Load();
                context.BalanceTypes.Load();
                context.Corps.Load();
                context.Rooms.Load();
                context.Equipments.Include("EmployeeEquipments").Include("RoomEquipments").Load();
                var query = context.RoomEquipments.AsQueryable();

                if (manufacturer.Manufacturer_ID > 0)
                {
                    query = query.Where(equipment => equipment.Equipment.Manufacturer_ID == manufacturer.Manufacturer_ID);
                }
                if (equipmentType.EquipmentType_ID > 0)
                {
                    query = query.Where(equipment => equipment.Equipment.EquipmentType_ID == equipmentType.EquipmentType_ID);
                }
                if (balanceType.BalanceType_ID > 0)
                {
                    query = query.Where(equipment => equipment.Equipment.BalanceType_ID == balanceType.BalanceType_ID);
                }
                if (!string.IsNullOrWhiteSpace(serial))
                {
                    query = query.Where(equipment => equipment.Equipment.Serial.Contains(serial));
                }
                if (!string.IsNullOrWhiteSpace(inventory))
                {
                    query = query.Where(equipment => equipment.Equipment.InventoryNumber.Contains(inventory));
                }
                if (!string.IsNullOrWhiteSpace(equipName))
                {
                    query = query.Where(equipment => equipment.Equipment.EquipmentName.Contains(equipName));
                }
                if (corps.Corps_ID > 0)
                {
                    query = query.Where(equipment => equipment.Room.Corps_ID == corps.Corps_ID);
                }
                if (room != null && room.Room_ID > 0)
                {
                    query = query.Where(equipment => equipment.Room_ID == room.Room_ID);
                }
                return query.ToList();
            }
        }

        /// <summary>
        /// Поиск оборудования по заданным параметрам
        /// </summary>
        public List<Equipment> FindEquipments(Manufacturer manufacturer, EquipmentType equipmentType,
            BalanceType balanceType, string serial, string inventory, string equipName)
        {
            using (var context = new EquipmentDBEntities())
            {
                context.Organizations.Load();
                context.EquipmentTypes.Load();
                context.Manufacturers.Load();
                context.BalanceTypes.Load();
                context.WriteOffEquipments.Load();
                context.Posts.Load();
                context.Employees.Load();
                context.Corps.Load();
                context.Rooms.Load();
                context.EquipmentLeasings.Include("EmployeeEquipments").Load();
                var query = context.Equipments.Include("EmployeeEquipments").Include("RoomEquipments").Include("WriteOffEquipments").AsQueryable();
                if (manufacturer.Manufacturer_ID > 0)
                {
                    query = query.Where(equipment => equipment.Manufacturer_ID == manufacturer.Manufacturer_ID);
                }
                if (equipmentType.EquipmentType_ID > 0)
                {
                    query = query.Where(equipment => equipment.EquipmentType_ID == equipmentType.EquipmentType_ID);
                }
                if (balanceType.BalanceType_ID > 0)
                {
                    query = query.Where(equipment => equipment.BalanceType_ID == balanceType.BalanceType_ID);
                }
                if (!string.IsNullOrWhiteSpace(serial))
                {
                    query = query.Where(equipment => equipment.Serial.Contains(serial));
                }
                if (!string.IsNullOrWhiteSpace(inventory))
                {
                    query = query.Where(equipment => equipment.InventoryNumber.Contains(inventory));
                }
                if (!string.IsNullOrWhiteSpace(equipName))
                {
                    query = query.Where(equipment => equipment.EquipmentName.Contains(equipName));
                }
                return query.ToList();
            }
        }

        #endregion

        /// <summary>
        /// Метод импорта данных сотрудников в БД из файла Excel
        /// </summary>
        public int ImportEmployeeFromFile(string path)
        {
            var fileLoader = new EmployeeFileLoader();
            var count = 0;
            try
            {
                using (var context = new EquipmentDBEntities())
                {
                    foreach (var employee in fileLoader.LoadFromFile(path))
                    {
                        // если в строке с должностью нет записи пропускаем
                        if (string.IsNullOrWhiteSpace(employee.Post.PostName)) continue;

                        // проверяем наличие должности в БД
                        var post = context.Posts.AsQueryable().FirstOrDefault(p => p.PostName == employee.Post.PostName);
                        if (post == null)
                        {
                            post = context.Posts.Add(new Post { PostName = employee.Post.PostName });
                            context.SaveChanges();
                        }

                        // проверяем наличие организации в БД
                        var organization = context.Organizations.AsQueryable().FirstOrDefault(o => o.OrganizationName == employee.Organization.OrganizationName);
                        if (organization == null)
                        {
                            organization = context.Organizations.Add(new Organization() { OrganizationName = employee.Organization.OrganizationName });
                            context.SaveChanges();
                        }

                        // проверяем наличие сотрудника в БД
                        if (!context.Employees.AsQueryable().Any(
                            emp => emp.FName.ToLower() == employee.FName.ToLower() &&
                                   emp.EmpName.ToLower() == employee.EmpName.ToLower() &&
                                   emp.LName.ToLower() == employee.LName.ToLower() &&
                                   emp.Post.PostName.ToLower() == employee.Post.PostName.ToLower()))
                        {
                            employee.Post_ID = post.Post_ID;
                            employee.Post = null;
                            employee.Organization_ID = organization.Organization_ID;
                            employee.Organization = null;
                            employee.IsArchive = false;

                            context.Employees.Add(employee);
                            count++;
                        }
                    }
                    context.SaveChanges();
                    return count;
                }

            }
            catch (Exception e)
            {
                HandleException(e);
                return 0;
            }
        }

        /// <summary>
        /// Асинхронный Метод импорта данных сотрудников в БД из файла Excel
        /// </summary>
        public async Task<int> ImportEmployeeFromFileAsync(string path)
        {
            return await Task.Run(() => ImportEmployeeFromFile(path));
        }

        /// <summary>
        /// Метод поиска сотрудникам по атрибутам
        /// </summary>
        public List<Employee> FindEmployees(string fName, string name, string lName, Post post)
        {
            using (var context = new EquipmentDBEntities())
            {
                context.Organizations.Load();
                context.Posts.Load();
                context.EquipmentLeasings.Include("EmployeeEquipments").Load();
                var query = context.Employees.Include("EquipmentLeasings1").AsQueryable();
                if (!string.IsNullOrWhiteSpace(fName))
                {
                    query = query.Where(employee => employee.FName.ToLower().Contains(fName));
                }
                if (!string.IsNullOrWhiteSpace(name))
                {
                    query = query.Where(employee => employee.EmpName.ToLower().Contains(name));
                }
                if (!string.IsNullOrWhiteSpace(lName))
                {
                    query = query.Where(employee => employee.LName.ToLower().Contains(lName));
                }
                if (post.Post_ID > 0)
                {
                    query = query.Where(employee => employee.Post_ID == post.Post_ID);
                }
                return query.ToList();
            }
        }


        #region CRUD операции

        /// <summary>
        /// Метод обновления сущности
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <param name="entity">Объект сущности</param>
        /// <returns></returns>
        public bool UpdateEntity<T>(T entity) where T : class
        {
            using (var context = new EquipmentDBEntities())
            {
                context.Set<T>().Add(entity);
                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Метод удаления сущности
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <param name="entity">Объект удаляемой сущности</param>
        /// <param name="predicat">Условие поиска сущности в БД</param>
        /// <returns></returns>
        public bool RemoveEntity<T>(T entity, Func<T, bool> predicat) where T : class
        {
            using (var context = new EquipmentDBEntities())
            {
                var ent = context.Set<T>().FirstOrDefault(predicat);
                if (ent == null) return false;
                context.Set<T>().Remove(ent);
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Метод выбора коллекции сущностей по указнному условию предиката
        /// </summary>
        public List<T> GetEntityes<T>(Func<T, bool> predicate) where T : class
        {
            using (var context = new EquipmentDBEntities())
            {
                if (typeof(T).Name == "WriteOffEquipment")
                {
                    context.EquipmentTypes.Load();
                    context.Manufacturers.Load();
                    context.BalanceTypes.Load();
                    context.Equipments.Load();
                }
                if (typeof(T).Name == "EmployeeRoom")
                {
                    context.Organizations.Load();
                    context.Corps.Load();
                    context.Posts.Load();
                    context.Rooms.Load();
                    context.Employees.Load();
                }
                if (typeof(T).Name == "EmployeeEquipment")
                {
                    context.BalanceTypes.Load();
                    context.Manufacturers.Load();
                    context.EquipmentTypes.Load();
                    context.Equipments.Include("EmployeeEquipments").Include("RoomEquipments").Include("WriteOffEquipments").Load();
                    context.EmployeeEquipments.Include("EquipmentLeasing").Load();
                }
                if (typeof(T).Name == "EquipmentLeasing")
                {
                    context.Organizations.Load();
                    context.Posts.Load();
                    context.Employees.Load();
                    context.Equipments.Load();
                    context.EquipmentTypes.Load();
                    context.Manufacturers.Load();
                    context.EquipmentLeasings.Include("EmployeeEquipments").Load();

                }
                if (typeof(T).Name == "User")
                {
                    context.Organizations.Load();
                    context.Posts.Load();
                    context.Employees.Load();
                }

                if (typeof(T).Name == "Equipment")
                {
                    context.Organizations.Load();
                    context.EquipmentTypes.Load();
                    context.Manufacturers.Load();
                    context.BalanceTypes.Load();
                    context.WriteOffEquipments.Load();
                    context.Posts.Load();
                    context.Employees.Load();
                    context.Corps.Load();
                    context.Rooms.Load();
                    context.EquipmentLeasings.Include("EmployeeEquipments").Load();
                    return
                        predicate == null ?
                        context.Set<T>().Include("EmployeeEquipments").Include("RoomEquipments").Include("WriteOffEquipments").ToList() :
                        context.Set<T>().Include("EmployeeEquipments").Include("RoomEquipments").Include("WriteOffEquipments").Where(predicate).ToList();
                }
                if (typeof(T).Name == "RoomEquipment")
                {
                    context.EquipmentTypes.Load();
                    context.Manufacturers.Load();
                    context.BalanceTypes.Load();
                    context.Corps.Load();
                    context.Rooms.Load();
                    context.WriteOffEquipments.Load();
                    context.Equipments.Include("EmployeeEquipments").Include("RoomEquipments").Include("WriteOffEquipments").Load();
                    return predicate == null ? context.Set<T>().ToList() :
                        context.Set<T>().Where(predicate).ToList();
                }
                if (typeof(T).Name == "Employee")
                {

                    context.Posts.Load();
                    context.Organizations.Load();
                    //context.Equipments.Load();
                    context.EquipmentLeasings.Include("EmployeeEquipments").Load();
                    return predicate == null ?
                        context.Set<T>().Include("EquipmentLeasings1").ToList() :
                        context.Set<T>().Include("EquipmentLeasings1").Where(predicate).ToList();
                }
                if (typeof(T).Name == "Room")
                {
                    context.Organizations.Load();
                    context.Posts.Load();
                    context.Employees.Load();
                    context.Corps.Load();
                    context.EquipmentTypes.Load();
                    context.Manufacturers.Load();
                    context.BalanceTypes.Load();
                    context.Equipments.Load();
                    return predicate == null ?
                        context.Set<T>().Include("RoomEquipments").Include("EmployeeRooms").ToList() :
                        context.Set<T>().Where(predicate).ToList();
                }
                return predicate == null ? context.Set<T>().ToList() : context.Set<T>().Where(predicate).ToList(); ;
            }
        }

        /// <summary>
        /// Метод выбора коллекции сущностей
        /// </summary>
        public List<T> GetEntityes<T>() where T : class
        {
            return GetEntityes<T>(null);
        }

        /// <summary>
        /// Метод добавления сущности в БД
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <param name="entity">Объект сущности</param>
        public T AddEntity<T>(T entity) where T : class
        {
            using (var context = new EquipmentDBEntities())
            {
                var adedEntity = context.Set<T>().Add(entity);
                context.SaveChanges();
                return adedEntity;
            }
        }

        #endregion

        /// <summary>
        /// Метод обработки исключений
        /// </summary>
        public void HandleException(Exception exception)
        {
            var sb = new StringBuilder();
            var validationException = exception as DbEntityValidationException;
            if (validationException != null)
            {
                foreach (var dbEntityValidationResult in validationException.EntityValidationErrors)
                {
                    foreach (var dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        sb.AppendLine(dbValidationError.ErrorMessage);
                    }
                }
            }
            var innerEx = exception.InnerException ?? exception;
            while (true)
            {
                if (innerEx.InnerException == null)
                {
                    break;
                }
                innerEx = innerEx.InnerException;
            }
            MessageBox.Show(innerEx.Message + "\n" + sb, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //MessageBox.Show(innerEx.Message + "\n" + sb + "\n" + "Исключение получено в методе:\n" + exception.TargetSite + "\n Последний вызов:\n" + exception.StackTrace.Split('\\').First(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
