using System.Linq;

namespace EquipmentDB.Model
{
    public partial class EquipmentLeasing
    {
        public override string ToString()
        {
            return "";
        }

        public int EquipmentQuantity
        {
            get { return EmployeeEquipments.Sum(equip => equip.Quantity); }
        }

        public override bool Equals(object obj)
        {
            var item = obj as EquipmentLeasing;

            if (item != null)
            {
                return item.EquipmentLeasing_ID == EquipmentLeasing_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return EquipmentLeasing_ID;
        }
    }
}
