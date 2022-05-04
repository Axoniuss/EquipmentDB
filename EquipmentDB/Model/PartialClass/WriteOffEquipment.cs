namespace EquipmentDB.Model
{
    public partial class WriteOffEquipment
    {
        public override string ToString()
        {
            return "";
        }

        public EquipmentType EquipmentType
        {
            get { return Equipment.EquipmentType; }
        }

        public string InventoryNumber
        {
            get { return Equipment.InventoryNumber; }
        }

        public override bool Equals(object obj)
        {
            var item = obj as WriteOffEquipment;

            if (item != null)
            {
                return item.WriteOffEquipment_ID == WriteOffEquipment_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return WriteOffEquipment_ID;
        }
    }
}
