using System.Drawing;

namespace SolutionBook.uLearn
{
    public class RectangleTask
    {
		/// <summary>
		/// Проверка на наличие общих точек у двух прямоугольников.
		/// </summary>
		/// <param name="r1">Прямоугольник 1.</param>
		/// <param name="r2">Прямоугольник 2.</param>
		/// <returns>Есть ли общие точки у прямоугольников.</returns>
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			bool tooLeft = r1.Left > r2.Left + r2.Width;
			bool tooRight = r2.Left > r1.Left + r1.Width;
			bool tooHigh = r1.Top > r2.Top + r2.Height;
			bool tooLow = r2.Top > r1.Top + r1.Height;

			return !(tooLeft || tooRight || tooHigh || tooLow);
		}
		/// <summary>
		/// Вычисление площади пересечения прямоугольников.
		/// </summary>
		/// <param name="r1">Прямоугольник 1.</param>
		/// <param name="r2">Прямоугольник 2.</param>
		/// <returns>Площадь пересечения.</returns>
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			if (AreIntersected(r1, r2))
			{
				if (r1.Left == r2.Right || r1.Top == r2.Bottom || r1.Right == r2.Left || r1.Bottom == r2.Top)
					return 0;
				else
				{
					int maximumLeft = Math.Max(r1.Left, r2.Left);
					int minimumLeftWeight = Math.Min(r1.Right, r2.Right);
					int maximumTop = Math.Max(r1.Top, r2.Top);
					int minimumTopHeight = Math.Min(r1.Bottom, r2.Bottom);
					return (minimumLeftWeight - maximumLeft) * (minimumTopHeight - maximumTop);
				}
			}
			return 0;
		}
		/// <summary>
		/// Определение вложени ли один прямоугольник в другой.
		/// </summary>
		/// <param name="r1">Прямоугольник 1.</param>
		/// <param name="r2">Прямоугольник 2.</param>
		/// <returns>Номер вложенного прямоугольника или -1.</returns>
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			if (r1.Left <= r2.Left && r1.Right >= r2.Right && r1.Bottom >= r2.Bottom && r1.Top <= r2.Top)
				return 1;
			else if
				(r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Bottom <= r2.Bottom && r1.Top >= r2.Top)
				return 0;
			else
				return -1;
		}
	}
}
