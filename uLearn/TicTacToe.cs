namespace SolutionBook.uLearn
{
    public class TicTacToe
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        public static void Main()
        {
            Run("XXX OO. ...");
            Run("OXO XO. .XO");
            Run("OXO XOX OX.");
            Run("XOX OXO OXO");
            Run("... ... ...");
            Run("XXX OOO ...");
            Run("XOO XOO XX.");
            Run(".O. XO. XOX");
        }

        private static void Run(string description)
        {
            Console.WriteLine(description.Replace(" ", Environment.NewLine));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        private static Mark[,] CreateFromString(string str)
        {
            var field = str.Split(' ');
            var ans = new Mark[3, 3];
            for (int x = 0; x < field.Length; x++)
                for (var y = 0; y < field.Length; y++)
                    ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            return ans;
        }

        public static GameResult GetGameResult(Mark[,] field)
        {
            bool crossWin = IsWin(field, Mark.Cross, field.GetLength(0));
            bool circleWin = IsWin(field, Mark.Circle, field.GetLength(0));
            if ((crossWin && circleWin) || (!crossWin && !circleWin))
                return GameResult.Draw;
            else if (crossWin)
                return GameResult.CrossWin;
            else
                return GameResult.CircleWin;
        }

        public static bool IsWin(Mark[,] field, Mark mark, int fieldLength)
        {
            for (int i = 0; i < fieldLength; i++)
            {
                bool verticalWin = (field[i, 0] == field[i, 1] && field[i, 0] == field[i, 2]);
                bool horizontalWin = (field[0, i] == field[1, i] && field[0, i] == field[2, i]);
                if ((verticalWin && (Mark)field[i, 0] == mark) || (horizontalWin && (Mark)field[0, i] == mark))
                    return true;
            }

            bool diagonalWin = (field[0, 0] == field[1, 1] && field[0, 0] == field[2, 2]);
            bool diagonalWin2 = (field[2, 0] == field[1, 1] && field[2, 0] == field[0, 2]);
            return (diagonalWin && (Mark)field[1, 1] == mark) || (diagonalWin2 && (Mark)field[1, 1] == mark);
        }
    }
}
