namespace _03_Data_Annotations_Testing
{
    using System.Data.Entity;

    public class UserDB_Data_Annotations : DbContext
    {
        public UserDB_Data_Annotations() : base("name=UserDB_Data_Annotations")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}