namespace SolutionBook.uLearn
{
    public class AngryBirdsTask
    {
        /// <summary>
        /// Расчет угла прицеливания.
        /// </summary>
        /// <param name="v">Скорость снаряда.</param>
        /// <param name="distance">Дальность до цели.</param>
        /// <returns>Угол прицеливания</returns>
        public static double FindSightAngle(double v, double distance)
        {
            double g = 9.8;
            return Math.Asin(distance * g / (v * v)) / 2;
        }
    }
}
