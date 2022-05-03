using System.Collections.Generic;
using System.Linq;

namespace EquipmentDB.Model
{
    public partial class Employee
    {
        public override string ToString()
        {
            if (Employee_ID == 0)
            {
                return "Все сотрудники";
            }
            return FName + " " + EmpName[0] + ". " + LName[0] + ". " + "(" + Post + ")";
        }

        public string EmployeeFio
        {
            get
            {
                if (Employee_ID == 0) return "Все сотрудники";
                return FName + " " + EmpName[0] + ". " + LName[0] + ".";
            }
        }

        public string OrganizationStr => Organization?.OrganizationName ?? " - ";

        public List<Model.EmployeeEquipment> EquipmentList
        {
            get
            {
                return EquipmentLeasings1.Where(el => !el.IsArchive).SelectMany(leasing => leasing.EmployeeEquipments).ToList();
            }
            //get { return Enumerable.SelectMany(EquipmentLeasings1, el => el.EmployeeEquipments).ToList(); }
        }

        /// <summary>
        /// Количество оборудования в использовании
        /// </summary>
        public int EquipmentCount
        {
            get { return EquipmentList.Sum(empEq => empEq.Quantity); }
        }


        public override bool Equals(object obj)
        {
            var item = obj as Employee;

            if (item != null)
            {
                return item.Employee_ID == Employee_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Employee_ID;
        }
    }
}
