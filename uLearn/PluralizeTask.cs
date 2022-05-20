namespace SolutionBook.uLearn
{
    public class PluralizeTask
    {
		/// <summary>
		/// Склонение "рублей".
		/// </summary>
		/// <param name="count">Количество рублей.</param>
		/// <returns>"Рубль" в правильном склонении</returns>
		public static string PluralizeRubles(int count)
		{
			if (((count % 100 > 4) && (count % 100 < 21)) || ((count % 10 > 4) || (count % 10 == 0)))
			{
				return "рублей";
			}
			else if (count % 10 > 1 && count % 10 < 5)
			{
				return "рубля";
			}
			else return "рубль";
		}
	}
}
