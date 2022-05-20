namespace SolutionBook
{
    public class ToPhoneNumber
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }
    }
}
