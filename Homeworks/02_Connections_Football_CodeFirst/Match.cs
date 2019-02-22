using System.Collections.Generic;

namespace _02_Connections_Football_CodeFirst
{
    class Match
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public Coach Coach1 { get; set; }
        public Coach Coach2 { get; set; }
        public Referee MatchReferee { get; set; }
        public int[] Score { get; set; }
        public string Stadium { get; set; }

        public virtual List<Player> Players { get; set; }
    }
}
