using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task21 : IPrintOfSolution
    {
        double P, e, y, h;

        public Task21(double e, double y, double h)
        {
            this.e = e;
            this.y = y;
            this.h = h;
        }

        public void PrintSolution()
        {
            P = Math.Pow(e, (y + 5.5)) + 9.1 * Math.Pow(h, 3);

            Console.WriteLine($"P = {P}");
        }
    }
}
