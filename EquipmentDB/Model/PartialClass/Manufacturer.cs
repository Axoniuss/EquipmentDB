namespace EquipmentDB.Model
{
    public partial class Manufacturer
    {
        public override string ToString()
        {
            return ManufacturerName ;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Manufacturer;

            if (item != null)
            {
                return item.Manufacturer_ID == Manufacturer_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Manufacturer_ID;
        }
    }
}
