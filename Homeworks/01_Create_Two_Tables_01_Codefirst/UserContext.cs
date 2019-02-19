using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace _01_Create_Two_Tables_01_Codefirst
{
    class UserContext : DbContext
    {
        public UserContext() : base("DbConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<SocialNetwork> Networks { get; set; }
    }
}
