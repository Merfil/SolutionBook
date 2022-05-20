using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBook
{
    public class Fibonachi
    {
        static int FibonachiCalc(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonachiCalc(n - 1) + FibonachiCalc(n - 2);
            }
        }
    }
}
