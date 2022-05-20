namespace SolutionBook
{
    public class BitCounter
    {
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
