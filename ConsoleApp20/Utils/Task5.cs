using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task5 : PrintOfSolution
    {
        double L, x;

        public Task5(double x)
        {
            this.x = x;
        }

        public void PrintSolution()
        {
            L = 1.51 * Math.Cos(Math.Pow(x, 2)) + 2 * Math.Pow(x, 3);

            Console.WriteLine($"L = {L}");
        }
    }
}
