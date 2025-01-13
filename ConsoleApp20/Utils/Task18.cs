using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task18 : IPrintOfSolution
    {
        double N, y;

        public Task18(double y)
        {
            this.y = y;
        }

        public void PrintSolution()
        {
            N = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Pow(y, 3) + 1);

            Console.WriteLine($"N = {N}");
        }
    }
}
