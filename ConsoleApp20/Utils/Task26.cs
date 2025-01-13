using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task26 : IPrintOfSolution
    {
        double Z, p;

        public Task26(double p)
        {
            this.p = p;
        }

        public void PrintSolution()
        {
            Z = Math.Pow(Math.Sin(Math.Pow(p, 2) + 0.4), 3);

            Console.WriteLine($"Z = {Z}");
        }
    }
}
