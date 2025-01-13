using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task9 : IPrintOfSolution
    {
        double V, y, x;

        public Task9(double y, double x)
        {
            this.y = y;
            this.x = x;
        }

        public void PrintSolution()
        {
            V = Math.Log(y + 0.95) + Math.Sin(Math.Pow(x, 4));

            Console.WriteLine($"V = {V}");
        }
    }
}
