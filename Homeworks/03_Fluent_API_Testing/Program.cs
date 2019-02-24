using System;

namespace _03_Fluent_API_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LaptopStore db = new LaptopStore())
            {
                Laptop hp = new Laptop
                {
                    Name = "HP Probook 255 G1",
                    Discount = 200,
                    Price = 768.5m
                };

                Company company = new Company()
                {
                    Name = "Hewlett-Packard",
                    Country = "USA",
                    City = "Some City",
                    Director = "Blabla Hafhaf",
                    Email = "info@hp.com",
                    Phone = "+787-4564564-4545",
                    Street ="New street 45"
                };

                db.Companies.Add(company);
                db.Laptops.Add(hp);
                db.SaveChanges();          
                
            }

            Console.ReadKey();
        }
    }
}
