namespace EquipmentDB.Model
{
    public partial class Organization
    {
        public override string ToString()
        {
            return OrganizationName;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Organization;

            if (item != null)
            {
                return item.Organization_ID == Organization_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Organization_ID;
        }
    }
}
