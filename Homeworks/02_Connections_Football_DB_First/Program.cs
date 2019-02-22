using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Connections_Football_DB_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FotballDataFirstEntities db = new FotballDataFirstEntities())
            {
                Team barca = new Team { Name = "Barcelona" };
                Team pyunik = new Team { Name = "FC Pyunik" };

                Coach BarcaCoach = new Coach { FirstName = "Ernesto", LastName = "Valverde" };
                Coach PyunikCoach = new Coach { FirstName = "Andrey", LastName = "Talalayev" };

                barca.Coaches.Add(BarcaCoach);
                pyunik.Coaches.Add(PyunikCoach);

                Referee referee = new Referee { FirstName = "Felix", LastName = "Brych" };
                Match UEFAFinal = new Match
                {
                    Date = new DateTime(2019,05,15),
                    Referee = referee,
                    Score = "1:1",
                    Stadium = "San-Siro",
                    Team = barca,
                    Team1 = pyunik                    
                };

                barca.Matches.Add(UEFAFinal);
                pyunik.Matches1.Add(UEFAFinal);

                Player t1p1 = new Player { FirstName = "Andre", LastName = "Ter Stegen"};
                barca.Players.Add(t1p1);
                Player t1p2 = new Player { FirstName = "Samuel", LastName = "Umtiti"};
                barca.Players.Add(t1p2);
                Player t1p3 = new Player { FirstName = "Gerard", LastName = "Pique"};
                barca.Players.Add(t1p3);
                Player t1p4 = new Player { FirstName = "Sergio", LastName = "Roberto"};
                barca.Players.Add(t1p4);
                Player t1p5 = new Player { FirstName = "Jordi", LastName = "Alba"};
                barca.Players.Add(t1p5);
                Player t1p6 = new Player { FirstName = "Samuel", LastName = "Busquets"};
                barca.Players.Add(t1p6);
                Player t1p7 = new Player { FirstName = "Ivan", LastName = "Rakitich"};
                barca.Players.Add(t1p7);
                Player t1p8 = new Player { FirstName = "Felipe", LastName = "Coutinho"};
                barca.Players.Add(t1p8);
                Player t1p9 = new Player { FirstName = "Leo", LastName = "Messi"};
                barca.Players.Add(t1p9);
                Player t1p10 = new Player { FirstName = "Luis", LastName = "Suares"};
                barca.Players.Add(t1p10);
                Player t1p11 = new Player { FirstName = "Usman", LastName = "Dembele"};
                barca.Players.Add(t1p11);
                Player t1s1 = new Player { FirstName = "Jesper", LastName = "Cilessen"};
                barca.Players.Add(t1s1);
                Player t1s2 = new Player { FirstName = "J.", LastName = "Murillo"};
                barca.Players.Add(t1s2);
                Player t1s3 = new Player { FirstName = "N.", LastName = "Semedo"};
                barca.Players.Add(t1s3);
                Player t1s4 = new Player { FirstName = "C.", LastName = "Alena"};
                barca.Players.Add(t1s4);

                Player t2p1 = new Player { FirstName = "Gor", LastName = "Manukyan"};
                pyunik.Players.Add(t2p1);
                Player t2p2 = new Player { FirstName = "Maksim", LastName = "Zhestokov" };
                pyunik.Players.Add(t2p2);
                Player t2p3 = new Player { FirstName = "Artur", LastName = "Kartashyan" };
                pyunik.Players.Add(t2p3);
                Player t2p4 = new Player { FirstName = "Serob", LastName = "Grigoryan" };
                pyunik.Players.Add(t2p4);
                Player t2p5 = new Player { FirstName = "Vyacheslav", LastName = "Dmitiyev" };
                pyunik.Players.Add(t2p5);
                Player t2p6 = new Player { FirstName = "Karlen", LastName = "Mkrtchyan" };
                pyunik.Players.Add(t2p6);
                Player t2p7 = new Player { FirstName = "Hovhannes", LastName = "Poghosyan" };
                pyunik.Players.Add(t2p7);
                Player t2p8 = new Player { FirstName = "Alik", LastName = "Arakelyan" };
                pyunik.Players.Add(t2p8);
                Player t2p9 = new Player { FirstName = "Mohamed", LastName = "Konate"};
                pyunik.Players.Add(t2p9);
                Player t2p10 = new Player { FirstName = "Artur", LastName = "Muranyan" };
                pyunik.Players.Add(t2p10);
                Player t2p11 = new Player { FirstName = "Denis", LastName = "Dorozhkin" };
                pyunik.Players.Add(t2p11);
                Player t2s1 = new Player { FirstName = "Evgeni", LastName = "Kobozev" };
                pyunik.Players.Add(t2s1);
                Player t2s2 = new Player { FirstName = "Vitaliy", LastName = "Stezhko" };
                pyunik.Players.Add(t2s2);
                Player t2s3 = new Player { FirstName = "Vahagn", LastName = "Hayrapetyan" };
                pyunik.Players.Add(t2s3);
                Player t2s4 = new Player { FirstName = "Rumyan", LastName = "Hovsepyan" };
                pyunik.Players.Add(t2s4);


                db.Coaches.Add(BarcaCoach);
                db.Coaches.Add(PyunikCoach);
                db.Referees.Add(referee);
                db.Players.AddRange(new List<Player>
                {
                    t1p1, t1p2, t1p3, t1p4, t1p5, t1p6, t1p7, t1p8, t1p9, t1p10, t1p11,
                    t2p1, t2p2, t2p3, t2p4, t2p5, t2p6, t2p7, t2p8, t2p9, t2p10, t2p11,
                    t1s1, t1s2, t1s3, t1s4, t2s1, t2s2, t2s3, t2s4
                });
                db.Matches.Add(UEFAFinal);
                db.SaveChanges();
                Console.ReadKey();
            }
        }
    }
}
