using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Create_Two_Tables_03_Model_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LibContext lib  = new LibContext())
            {
                Author raffi = new Author()
                {
                    Name = "Raffi",
                    BirthDay = "1850",
                    Nationality = "Armenian"

                };

                Author ayl = new Author()
                {
                    Name = "Anhayt",
                    BirthDay = "1995",
                    Nationality = "Uzbek"
                };

                Book book1 = new Book()
                {
                    Name = "Rafu Samvel",
                    Pages = 650,
                    Title = "Janjal girq",
                    Year = 1900,
                    AuthorId = 1
                };

                Book book2 = new Book()
                {
                    Name = "Ayl",
                    Pages = 100,
                    Title = "Urish meky",
                    Year = 2000,
                    AuthorId = 2
                };

                lib.Authors.Add(raffi);
                lib.Authors.Add(ayl);
                lib.Books.Add(book1);
                lib.Books.Add(book2);
                lib.SaveChanges();

                var a = lib.Books.Where(x => x.Pages > 150).Select(x => new { nm = x.Name, auth = x.Author.Name }).FirstOrDefault();

                Console.WriteLine($"{a.nm}\n{a.auth}");
                Console.ReadKey();
            }

                
        }
    }
}
