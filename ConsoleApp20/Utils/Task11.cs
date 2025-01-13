using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task11 : IPrintOfSolution
    {
        double S, y, x;

        public Task11(double y, double x)
        {
            this.y = y;
            this.x = x;
        }

        public void PrintSolution()
        {
            S = 9.756 * Math.Pow(y, 7) + 2 * Math.Tan(x);

            Console.WriteLine($"S = {S}");
        }
    }
}
