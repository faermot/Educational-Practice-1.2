using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task2 : PrintOfSolution
    {
        double K, p, y, e;

        public Task2(double p, double y, double e)
        {
            this.p = p;
            this.y = y;
            this.e = e;
        }

        public void PrintSolution()
        {
            K = Math.Log(Math.Pow(p, 2) + Math.Pow(y, 3)) + Math.Pow(e, p);

            Console.WriteLine($"K = {K}");
        }
    }
}
