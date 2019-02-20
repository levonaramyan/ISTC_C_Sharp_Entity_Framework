using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Create_Two_Tables_02_Database_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext socNet = new MyContext())
            {
                foreach (User user in socNet.Users)
                {
                    Console.WriteLine($"First Name: {user.FirstName}");
                    Console.WriteLine($"Last Name: {user.LastName}");
                    Console.WriteLine($"Age: {user.Age}");
                    Console.WriteLine($"Social network Id: {user.Network_Id}");
                    Console.WriteLine($"S. Netowrk Name: {user.SocialNetwork.Name}");
                    Console.WriteLine($"S. Netowrk website: {user.SocialNetwork.Website}");
                }

                Console.ReadKey();
            }
        }
    }
}
