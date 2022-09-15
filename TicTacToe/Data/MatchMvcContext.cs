using Microsoft.EntityFrameworkCore;
using TicTacToe.Entities;

namespace TicTacToe.Data
{
    public class MatchMvcContext : DbContext
    {
        public MatchMvcContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
    }
}
