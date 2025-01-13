using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task8 : IPrintOfSolution
    {
        double T, y;

        public Task8(double y)
        {
            this.y = y;
        }
        public void PrintSolution()
        {
            T = Math.Sqrt(Math.Abs(6 * Math.Pow(y, 2) - 0.1 * y + 4));

            Console.WriteLine($"T = {T}");
        }
    }
}
