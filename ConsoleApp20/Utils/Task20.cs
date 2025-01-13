using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task20 : IPrintOfSolution
    {
        double U, e, k, y, x;

        public Task20(double e, double k, double y, double x)
        {
            this.e = e;
            this.k = k;
            this.y = y;
            this.x = x;
        }

        public void PrintSolution()
        {
            U = Math.Pow(e, (k + y)) + Math.Tan(x * Math.Sqrt(y));

            Console.WriteLine($"U = {U}");
        }
    }
}
