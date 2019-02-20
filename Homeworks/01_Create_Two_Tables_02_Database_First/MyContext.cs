using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _01_Create_Two_Tables_02_Database_First
{
    class MyContext : DbContext
    {
        public MyContext() : base("UsersAndNetworks")
        {

        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<SocialNetwork> SocialNetworks { get; set; }
    }
}
