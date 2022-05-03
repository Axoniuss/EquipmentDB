namespace EquipmentDB.Model
{
    public partial class BalanceType
    {
        public override string ToString()
        {
            return BalanceTypeName ;
        }

        public override bool Equals(object obj)
        {
            var item = obj as BalanceType;

            if (item != null)
            {
                return item.BalanceType_ID == BalanceType_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return BalanceType_ID;
        }
    }
}
