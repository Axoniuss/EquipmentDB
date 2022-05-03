namespace EquipmentDB.Model
{
    public partial class EquipmentType
    {
        public override string ToString()
        {
            return EquipmentTypeName;
        }

        public override bool Equals(object obj)
        {
            var item = obj as EquipmentType;

            if (item != null)
            {
                return item.EquipmentType_ID == EquipmentType_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return EquipmentType_ID;
        }
    }
}
