namespace TicTacToe.Entities
{
    public class Match
    {

        public Player PlayerX { get; set; }
        public Player PlayerO { get; set; }
        public Board Board { get; set; }
        public Match(Player playerX, Player playerO)
        {
            Board = new Board();
            PlayerX = playerX;
            PlayerO = playerO;
        }

    }


}
