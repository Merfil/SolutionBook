using System.Text.RegularExpressions;

namespace SolutionBook
{
    public class Vowels_removed
    {
        //Note: for this kata y isn't considered a vowel.
        public static string Disemvowel(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }
    }
}
