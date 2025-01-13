using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task23 : IPrintOfSolution
    {
        double G, e, f, y;

        public Task23(double e, double f, double y)
        {
            this.e = e;
            this.f = f;
            this.y = y;
        }

        public void PrintSolution()
        {
            G = Math.Pow(e, 2 * y) + Math.Sin(f);

            Console.WriteLine($"G = {G}");
        }
    }
}
