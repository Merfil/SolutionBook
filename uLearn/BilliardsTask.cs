namespace SolutionBook.uLearn
{
    public class BilliardsTask
    {
        /// <summary>
        /// Расчет угла отскока шара от стены.
        /// </summary>
        /// <param name="directionRadians">Угол направления движения шара относительно горизонтали.</param>
        /// <param name="wallInclinationRadians">Угол стены относительно горизонтали.</param>
        /// <returns>Угол отскока шара относительно горизонтали.</returns>
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            //TODO
            return wallInclinationRadians - directionRadians + wallInclinationRadians;
        }
    }
}
