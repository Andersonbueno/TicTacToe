using TicTacToe.Data;
using TicTacToe.Entities;

namespace TicTacToe.Services
{
    public class MatchService
    {


        private readonly MatchMvcContext _matchMvcContext;

        public MatchService(MatchMvcContext matchMvcContext)
        {
            _matchMvcContext = matchMvcContext;
        }

        public List<Match> FindAll()
        {
            return _matchMvcContext.Matches.ToList();
        }

        public Player? FindMatchesByPlayer(string username)
        {
            var playerDb = from player in _matchMvcContext.Players select player;

            int size = playerDb.Where(player => player.Name == username).ToList().Count;//TODO 

            if(size == 0) return null;

            return playerDb.First();       
        }

        public void NewMatch(string nameX, string nameO)
        {
            Player player = new Player(nameX);
            Player player2 = new Player(nameO);

            Match newMatch = new Match(player, player2);

            var matchDb = from match in _matchMvcContext.Matches select match;

            matchDb.Append(newMatch);

            //var get

            //_matchMvcContext.Matches.
        }
    }
}
