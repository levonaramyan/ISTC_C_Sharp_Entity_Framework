using System;

namespace _03_Data_Annotations_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserDB_Data_Annotations db = new UserDB_Data_Annotations())
            {
                Company comp1 = new Company { Name = "NewCompany" };
                ContactInfo info = new ContactInfo
                {
                    Address = "Some street, 24",
                    Email = "somemail@somedomain.com",
                    Phone = "+545-7879-5789"
                };

                User user = new User
                {
                    Name = "Adasfasjghfgasyf",
                    Surname = "West",
                    Company = comp1,
                    IsInvalid = true,
                    Contacts = info
                };

                db.Companies.Add(comp1);
                db.Users.Add(user);
                db.SaveChanges();
            }

            Console.WriteLine("Success!!!");

            Console.ReadKey();
        }
    }
}
