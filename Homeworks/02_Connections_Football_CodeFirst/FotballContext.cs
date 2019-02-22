
using System.Data.Entity;

namespace _02_Connections_Football_CodeFirst
{
    class FotballContext: DbContext
    {
        public FotballContext(): base ("FotballMatches")
        {

        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Referee> Referees { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
    }
}
