namespace EquipmentDB.Model
{
    public partial class Corps
    {
        public override string ToString()
        {
            return CorpsName;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Corps;

            if (item != null)
            {
                return item.Corps_ID == Corps_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Corps_ID;
        }
    }
}
