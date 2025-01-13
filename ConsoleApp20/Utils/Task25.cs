using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task25 : IPrintOfSolution
    {
        double G, e, y, f;

        public Task25(double e, double y, double f)
        {
            this.e = e;
            this.y = y;
            this.f = f;
        }

        public void PrintSolution()
        {
            G = e * Math.Pow(2, y) + Math.Sin(Math.Pow(f, 2));

            Console.WriteLine($"G = {G}");
        }
    }
}
