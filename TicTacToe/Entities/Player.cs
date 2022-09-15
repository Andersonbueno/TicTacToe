namespace TicTacToe.Entities
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; private set; }


        public Player()
        {
        }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }        

        protected void MatchPoint()
        {
            Score++;
        }
    }
}
