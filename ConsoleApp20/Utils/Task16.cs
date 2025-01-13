using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task16 : IPrintOfSolution
    {
        double S, y;

        public Task16(double y)
        {
            this.y = y;
        }

        public void PrintSolution()
        {
            S = Math.Sqrt(Math.Cos(4 * Math.Pow(y, 2))) + 7.151;

            Console.WriteLine($"S = {S}");
        }
    }
}
