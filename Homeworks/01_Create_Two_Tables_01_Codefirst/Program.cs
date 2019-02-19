using System;

namespace _01_Create_Two_Tables_01_Codefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                SocialNetwork facebook = new SocialNetwork()
                    {
                        Name = "Facebook",
                        Website = @"https://www.facebook.com/",
                        AllowsPaidAdds = true
                    };

                SocialNetwork linkedin = new SocialNetwork()
                {
                    Name = "LinkedIn",
                    Website = @"https://www.linkedin.com/",
                    AllowsPaidAdds = true
                };

                User user1 = new User()
                {
                    FirstName = "Levon",
                    LastName = "Aramyan",
                    Age = 28,
                    Network = facebook
                };

                User user2 = new User()
                {
                    FirstName = "John",
                    LastName = "West",
                    Age = 20,
                    Network = linkedin
                };

                db.Networks.Add(facebook);
                db.Networks.Add(linkedin);
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();

                var users = db.Users;
                Console.WriteLine("Below are the list of object:");
                foreach(var user in users)
                    Console.WriteLine($"{user.Id}\t{user.FirstName}\t{user.LastName}\t{user.Age}\t{user.Network.Name}");

                Console.ReadKey();
            }
        }
    }
}
