namespace TicTacToe.Exceptions
{
    public class PositionIsFilledException : Exception
    {
        public PositionIsFilledException(string? message) : base(message)
        {
        }
    }
}
