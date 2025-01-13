using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task17 : IPrintOfSolution
    {
        double N, y;

        public Task17(double y)
        {
            this.y = y;
        }

        public void PrintSolution()
        {
            N = 3 * Math.Pow(y, 2) + Math.Sqrt(y + 1);

            Console.WriteLine($"N = {N}");
        }
    }
}
