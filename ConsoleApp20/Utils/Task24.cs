using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task24 : IPrintOfSolution
    {
        double F, y;

        public Task24(double y)
        {
            this.y = y;
        }

        public void PrintSolution()
        {
            F = 2 * Math.Sin(0.214 * Math.Pow(y, 5)) + 1;

            Console.WriteLine($"F = {F}");
        }
    }
}
