using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EquipmentDB.Model;

namespace EquipmentDB.Controller
{
    public interface IRepository
    {
        void CreateBackup(string bakFilePath);

        void RestoreDatabase(string bakFilePath);
        bool FirstStart();

        User GetCurrentUser();

        void UserLogin(string login, string password);

        /// <summary>
        /// Поиск списанного оборудования по заданным параметрам
        /// </summary>
        List<WriteOffEquipment> FindWriteOffEquipments(Manufacturer manufacturer, EquipmentType eqType, BalanceType balanceType, string serial,
            string inventory, string equipName, string orderNumber, DateTime? orderDate);

        /// <summary>
        /// Поиск оборудования во временном использовании
        /// </summary>
        List<EquipmentLeasing> FindEquipmentLeasings(Employee employeeOut, Employee employeeIn, DateTime? dtEnter, DateTime? dtReturn, string inventory, bool isArchiveSearc);

        /// <summary>
        /// Метод поиска оборудования в эксплуатации по заданным параметрам
        /// </summary>
        /// <param name="manufacturer">Производитель</param>
        /// <param name="equipmentType">Тип оборудования</param>
        /// <param name="balanceType">Тип учёта</param>
        /// <param name="serial">Серийный номер</param>
        /// <param name="inventory">Инвентарный номер</param>
        /// <param name="equipName">Название оборудования</param>
        /// <param name="corps">Корпус</param>
        /// <param name="room">Помещение</param>
        List<RoomEquipment> FindRoomEquipments(Manufacturer manufacturer, EquipmentType equipmentType,
            BalanceType balanceType, string serial, string inventory, string equipName, Corps corps, Room room);

        /// <summary>
        /// Поиск оборудования по заданным параметрам
        /// </summary>
        /// <param name="manufacturer">Производитель</param>
        /// <param name="equipmentType">Тип оборудования</param>
        /// <param name="status">Статус оборудования</param>
        /// <param name="balanceType">Тип учёта</param>
        /// <param name="serial">Серийный номер</param>
        /// <param name="inventory">Инвентарный номер</param>
        /// <param name="equipName">Название оборудования</param>
        List<Equipment> FindEquipments(Manufacturer manufacturer, EquipmentType equipmentType,
            BalanceType balanceType, string serial, string inventory, string equipName);

        /// <summary>
        /// Асинхронный метод импорта данных сотрудников с файла
        /// </summary>
        Task<int> ImportEmployeeFromFileAsync(string path);

        /// <summary>
        /// Метод импорта данных сотрудников с файла
        /// </summary>
        int ImportEmployeeFromFile(string path);

        /// <summary>
        /// Метод поиска сотрудникам по атрибутам
        /// </summary>
        List<Employee> FindEmployees(string fName, string name, string lName, Post post);

        /// <summary>
        /// Метод обновления сущности
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <param name="entity">Объект сущности</param>
        /// <returns></returns>
        bool UpdateEntity<T>(T entity) where T : class;

        /// <summary>
        /// Метод удаления сущности
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <param name="entity">Объект удаляемой сущности</param>
        /// <param name="predicat">Условие поиска сущности в БД</param>
        /// <returns></returns>
        bool RemoveEntity<T>(T entity, Func<T, bool> predicat) where T : class;

        /// <summary>
        /// Метод выбора коллекции сущностей по указнному условию предиката
        /// </summary>
        List<T> GetEntityes<T>(Func<T, bool> predicate) where T : class;

        /// <summary>
        /// Метод выбора коллекции сущностей
        /// </summary>
        List<T> GetEntityes<T>() where T : class;

        /// <summary>
        /// Метод добавления сущности в БД
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <param name="entity">Объект сущности</param>
        T AddEntity<T>(T entity) where T : class;

        /// <summary>
        /// Метод обработки исключений
        /// </summary>
        void HandleException(Exception exception);
    }
}
