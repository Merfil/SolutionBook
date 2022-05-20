namespace SolutionBook
{
    public class Vowels_count
    {
        public static int GetVowelCount(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }
    }
}
