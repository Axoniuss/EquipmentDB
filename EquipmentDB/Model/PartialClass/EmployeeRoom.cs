namespace EquipmentDB.Model
{
    public partial class EmployeeRoom
    {
        public override string ToString()
        {
            return Employee +" "+Room;
        }

        public string EmployeeStr
        {
            get { return Employee.ToString(); }
        }

        public string RoomStr
        {
            get { return Room.ToString(); }
        }

        public override bool Equals(object obj)
        {
            var item = obj as EmployeeRoom;

            if (item != null)
            {
                return item.EmployeeRoom_ID == EmployeeRoom_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return EmployeeRoom_ID;
        }
    }
}
