using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task14 : IPrintOfSolution
    {
        double R, y, e, x;

        public Task14(double y, double e, double x)
        {
            this.y = y;
            this.e = e;
            this.x = x;
        }

        public void PrintSolution()
        {
            R = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y), 2) + Math.Pow(e, x)));

            Console.WriteLine($"R = {R}");
        }
    }
}
