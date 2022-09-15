using TicTacToe.Exceptions;

namespace TicTacToe.Entities
{
    public class Board
    {
        public string[,] Table { get; private set; }

        public int Size { get; set; }

        public Board()
        {
            Table = new string[3, 3];
            Size = 3;
        }

        public bool MakeMove(int row, int column, string playerCode)
        {
            if (ShouldBetweenZeroAndTwo(row))
            {
                throw new PositionOutOfRangeException("The line exceeded the range of the board!");
            }

            if (ShouldBetweenZeroAndTwo(column))
            {
                throw new PositionOutOfRangeException("The column exceeded the range of the board!");
            }

            if (ShouldPositionNotBeNull(row, column))
            {
                throw new PositionIsFilledException("The position you are trying to insert is already filled!");
            }

            Table[row, column] = playerCode;

            return true;

        }

        public bool GameOver()
        {
            if (AnyRowIsFilled())
            {
                return false;
            }
            if (AnyColumnIsFilled())
            {
                return false;
            }
            if (AnyDiagonIsFilled())
            {
                return false;
            }

            return true;
        }

        private bool AnyRowIsFilled()
        {
            for (int i = 0; i < Size; i++)
            {
                string first = null;
                bool itWorks = true;

                for (int j = 0; j < Size; j++)
                {
                    string content = Table[i, j];

                    if (content == null) { break; }
                    first = (first == null) ? content : first;
                    if (content != first)
                    {
                        itWorks = false;
                        break;
                    }
                }
                if(itWorks) return true;
            }
            return false;
        }

        private bool AnyColumnIsFilled()
        {
            for (int i = 0; i < Size; i++)
            {
                string first = null;
                bool itWorks = true;

                for (int j = 0; j < Size; j++)
                {
                    string content = Table[j, i];
                    if (content == null) { break; }
                    first = (first == null) ? content : first;
                    if (content != first)
                    {
                        itWorks = false;
                        break;
                    }
                }
                if (itWorks) return true;
            }
            return false;
        }

        private bool AnyDiagonIsFilled()
        {
            string first = null;

            for (int i = 0; i < Size; i++)
            {
                string principalDiagon = Table[i, i];

                if (principalDiagon == null) { break; }
                first = (first == null) ? principalDiagon : first;

                if (principalDiagon != first) return false;
            }
            
            return true;
        }

        private bool ShouldBetweenZeroAndTwo(int position)
        {
            if (position < 0 || position > 2)
            {
                return false;
            }

            return true;
        }
        

        private bool ShouldPositionNotBeNull(int row, int column)
        {
            if (Table[row, column] == null)
            {
                return false;
            }

            return true;
        }

        
    }
}
