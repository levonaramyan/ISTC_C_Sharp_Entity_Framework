using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Connections_Football_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FotballContext db = new FotballContext())
            {                
                Coach BarcaCoach = new Coach { FirstName = "Ernesto", LastName = "Valverde" };
                Coach PyunikCoach = new Coach { FirstName = "Andrey", LastName = "Talalayev" };

                Referee referee = new Referee { FirstName = "Felix", LastName = "Brych" };
                Match UEFAFinal = new Match
                {
                    Coach1 = BarcaCoach,
                    Coach2 = PyunikCoach,
                    Date = "15.05.2019",
                    MatchReferee = referee,
                    Score = new int[] { 0, 0 },
                    Stadium = "San-Siro"
                };

                Player t1p1 = new Player { FirstName = "Andre", LastName = "Ter Stegen" , Coach = BarcaCoach};
                t1p1.Matches = new List<Match> { UEFAFinal};
                Player t1p2 = new Player { FirstName = "Samuel", LastName = "Umtiti", Coach = BarcaCoach };
                t1p2.Matches = new List<Match> { UEFAFinal};
                Player t1p3 = new Player { FirstName = "Gerard", LastName = "Pique", Coach = BarcaCoach };
                t1p3.Matches = new List<Match> { UEFAFinal};
                Player t1p4 = new Player { FirstName = "Sergio", LastName = "Roberto", Coach = BarcaCoach };
                t1p4.Matches = new List<Match> { UEFAFinal};
                Player t1p5 = new Player { FirstName = "Jordi", LastName = "Alba", Coach = BarcaCoach };
                t1p5.Matches = new List<Match> { UEFAFinal};
                Player t1p6 = new Player { FirstName = "Samuel", LastName = "Busquets", Coach = BarcaCoach };
                t1p6.Matches = new List<Match> { UEFAFinal};
                Player t1p7 = new Player { FirstName = "Ivan", LastName = "Rakitich", Coach = BarcaCoach };
                t1p7.Matches = new List<Match> { UEFAFinal};
                Player t1p8 = new Player { FirstName = "Felipe", LastName = "Coutinho", Coach = BarcaCoach };
                t1p8.Matches = new List<Match> { UEFAFinal};
                Player t1p9 = new Player { FirstName = "Leo", LastName = "Messi", Coach = BarcaCoach };
                t1p9.Matches = new List<Match> { UEFAFinal};
                Player t1p10 = new Player { FirstName = "Luis", LastName = "Suares", Coach = BarcaCoach };
                t1p10.Matches = new List<Match> { UEFAFinal};
                Player t1p11 = new Player { FirstName = "Usman", LastName = "Dembele", Coach = BarcaCoach };
                t1p11.Matches = new List<Match> { UEFAFinal};
                Player t1s1 = new Player { FirstName = "Jesper", LastName = "Cilessen", Coach = BarcaCoach };
                Player t1s2 = new Player { FirstName = "J.", LastName = "Murillo", Coach = BarcaCoach };
                Player t1s3 = new Player { FirstName = "N.", LastName = "Semedo", Coach = BarcaCoach };
                Player t1s4 = new Player { FirstName = "C.", LastName = "Alena", Coach = BarcaCoach };

                Player t2p1 = new Player { FirstName = "Gor", LastName = "Manukyan", Coach = PyunikCoach };
                t2p1.Matches = new List<Match> { UEFAFinal };
                Player t2p2 = new Player { FirstName = "Maksim", LastName = "Zhestokov", Coach = PyunikCoach };
                t2p2.Matches = new List<Match> { UEFAFinal };
                Player t2p3 = new Player { FirstName = "Artur", LastName = "Kartashyan", Coach = PyunikCoach };
                t2p3.Matches = new List<Match> { UEFAFinal };
                Player t2p4 = new Player { FirstName = "Serob", LastName = "Grigoryan", Coach = PyunikCoach };
                t2p4.Matches = new List<Match> { UEFAFinal };
                Player t2p5 = new Player { FirstName = "Vyacheslav", LastName = "Dmitiyev", Coach = PyunikCoach };
                t2p5.Matches = new List<Match> { UEFAFinal };
                Player t2p6 = new Player { FirstName = "Karlen", LastName = "Mkrtchyan", Coach = PyunikCoach };
                t2p6.Matches = new List<Match> { UEFAFinal };
                Player t2p7 = new Player { FirstName = "Hovhannes", LastName = "Poghosyan", Coach = PyunikCoach };
                t2p7.Matches = new List<Match> { UEFAFinal };
                Player t2p8 = new Player { FirstName = "Alik", LastName = "Arakelyan", Coach = PyunikCoach };
                t2p8.Matches = new List<Match> { UEFAFinal };
                Player t2p9 = new Player { FirstName = "Mohamed", LastName = "Konate", Coach = PyunikCoach };
                t2p9.Matches = new List<Match> { UEFAFinal };
                Player t2p10 = new Player { FirstName = "Artur", LastName = "Muranyan", Coach = PyunikCoach };
                t2p10.Matches = new List<Match> { UEFAFinal };
                Player t2p11 = new Player { FirstName = "Denis", LastName = "Dorozhkin", Coach = PyunikCoach };
                t2p11.Matches = new List<Match> { UEFAFinal };
                Player t2s1 = new Player { FirstName = "Evgeni", LastName = "Kobozev", Coach = PyunikCoach };
                Player t2s2 = new Player { FirstName = "Vitaliy", LastName = "Stezhko", Coach = PyunikCoach };
                Player t2s3 = new Player { FirstName = "Vahagn", LastName = "Hayrapetyan", Coach = PyunikCoach };
                Player t2s4 = new Player { FirstName = "Rumyan", LastName = "Hovsepyan", Coach = PyunikCoach };

                UEFAFinal.Players = new List<Player>
                {
                    t1p1,t1p2, t1p3, t1p4, t1p5, t1p6, t1p7, t1p8, t1p9, t1p10, t1p11,
                    t2p1,t2p2, t2p3, t2p4, t2p5, t2p6, t2p7, t2p8, t2p9, t2p10, t2p11
                };

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

                Console.WriteLine(db.Matches.FirstOrDefault().Date);
                Console.WriteLine(db.Matches.FirstOrDefault().Stadium);
                Console.WriteLine(new string('*', 150));
                Console.WriteLine($"Team 1:\nCoach: {db.Matches.FirstOrDefault().Coach1.FirstName} {db.Matches.FirstOrDefault().Coach1.LastName}");
                List<Player> players1 = db.Matches.FirstOrDefault().Players.Where(p => p.Coach.FirstName == "Ernesto").ToList();
                foreach (Player p in players1) Console.WriteLine($"{p.FirstName} {p.LastName}");

                Console.WriteLine(new string('*',150));
                Console.WriteLine($"Team 2:\nCoach: {db.Matches.FirstOrDefault().Coach2.FirstName} {db.Matches.FirstOrDefault().Coach2.LastName}");
                List<Player> players2 = db.Matches.FirstOrDefault().Players.Where(p => p.Coach.FirstName == "Andrey").ToList();
                foreach (Player p in players2) Console.WriteLine($"{p.FirstName} {p.LastName}");

                Console.ReadKey();
            }
        }
    }
}
