using LinqToExcel;
using System.Collections.Generic;
using System.Linq;


namespace EquipmentDB.Model
{
    public class EmployeeFileLoader
    {
        public IEnumerable<Employee> LoadFromFile(string path)
        {
            // для импорта сотрудников из файла Excel
            // используем LinqToExcel
            var book = new ExcelQueryFactory(path);
            var employees = (from x in book.Worksheet(0)
                             select new Employee
                             {
                                 FName = x["Фамилия"],
                                 EmpName = x["Имя"],
                                 LName = x["Отчество"],
                                 Phone = x["Мобильный телефон"],
                                 Post = new Post { PostName = x["Основная должность"], },
                                 Organization = new Organization() {OrganizationName = x["Организация"]}
                             }).AsEnumerable();
            return employees;
        }
    }
}
