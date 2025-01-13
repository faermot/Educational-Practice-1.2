using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task28 : IPrintOfSolution
    {
        double T, e, y, h;

        public Task28(double e, double y, double h)
        {
            this.e = e;
            this.y = y;
            this.h = h;
        }

        public void PrintSolution()
        {
            T = Math.Pow(e, y + h) + Math.Sqrt(Math.Abs(y * 6.4));

            Console.WriteLine($"T = {T}");
        }
    }
}
