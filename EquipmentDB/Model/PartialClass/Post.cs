namespace EquipmentDB.Model
{
    public partial class Post
    {
        public override string ToString()
        {
            return PostName;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Post;

            if (item != null)
            {
                return item.Post_ID == Post_ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Post_ID;
        }
    }
}
