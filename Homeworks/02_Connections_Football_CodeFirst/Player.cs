using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Connections_Football_CodeFirst
{
    class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public Coach Coach { get; set; }
        public virtual List<Match> Matches { get; set; }
    }
}
