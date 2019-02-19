using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Create_Two_Tables_01_Codefirst
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public SocialNetwork Network { get; set; }
    }

    class SocialNetwork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public bool AllowsPaidAdds { get; set; }
    }
}
