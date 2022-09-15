using Microsoft.EntityFrameworkCore;

namespace TicTacToe.Data
{
    public class BoardMvcContext : DbContext
    {
        public BoardMvcContext(DbContextOptions options) : base(options)
        {
        }
    }
}
