namespace EquipmentDB.Model
{
    public partial class RoomEquipment
    {

        public string EquipmentStr
        {
            get { return Equipment.ToString(); }
        }

        public string EquipTypeStr
        {
            get { return Equipment.EquipmentType.ToString(); }
        }

        public string EquipManufacturerStr
        {
            get { return Equipment.Manufacturer.ToString(); }
        }


        public string EquipInventoryNumber
        {
            get { return Equipment.InventoryNumber; }
        }


        //--------------------------------------------------------
        public override bool Equals(object obj)
        {
            var item = obj as RoomEquipment;

            if (item != null)
            {
                return item.RoomEquipment_ID == RoomEquipment_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Equipment_ID;
        }
    }
}
