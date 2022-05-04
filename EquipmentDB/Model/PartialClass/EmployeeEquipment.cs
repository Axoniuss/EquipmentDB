using System;

namespace EquipmentDB.Model
{
    public partial class EmployeeEquipment
    {
        public override string ToString()
        {
            return Equipment.ToString();
        }

        public DateTime DateIssue
        {
            get { return EquipmentLeasing.DateOfIssue; }
        }

        public DateTime DateReturn
        {
            get { return EquipmentLeasing.DateReturn; }
        }
        
        public string EquipmentStr
        {
            get { return Equipment.ToString(); }
        }

        public string InventoryNumber
        {
            get { return Equipment.InventoryNumber; }
        }

        public string Serial
        {
            get { return Equipment.Serial; }
        }

        public override bool Equals(object obj)
        {
            var item = obj as EmployeeEquipment;

            if (item != null)
            {
                return item.EmployeeEquipment_ID == EmployeeEquipment_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return EmployeeEquipment_ID;
        }
    }
}
