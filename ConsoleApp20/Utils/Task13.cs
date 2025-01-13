using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task13 : IPrintOfSolution
    {
        double E, y;

        public Task13(double y)
        {
            this.y = y;
        }

        public void PrintSolution()
        {
            E = Math.Sqrt(Math.Abs(3 * Math.Pow(y, 3) + 0.5 * y + 4));

            Console.WriteLine($"E = {E}");
        }
    }
}
