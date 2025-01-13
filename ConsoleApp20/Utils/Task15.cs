using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task15 : IPrintOfSolution
    {
        double H, y;

        public Task15(double y)
        {
            this.y = y;
        }

        public void PrintSolution()
        {
            H = Math.Sin(Math.Pow(y, 2)) - 2.8 * y + Math.Sqrt(Math.Abs(y));

            Console.WriteLine($"H = {H}");
        }
    }
}
