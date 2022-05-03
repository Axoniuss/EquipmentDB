namespace EquipmentDB.Model
{
    public partial class Room
    {
        public override string ToString()
        {
            return RoomName +" ("+Corps+")";
        }

        public override bool Equals(object obj)
        {
            var item = obj as Room;

            if (item != null)
            {
                return item.Room_ID == Room_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Room_ID;
        }
    }
}
