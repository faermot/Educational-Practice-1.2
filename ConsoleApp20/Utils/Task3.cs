using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task3 : PrintOfSolution
    {
        double G, n, y;

        public Task3(double n, double y)
        {
            this.n = n;
            this.y = y;
        }

        public void PrintSolution()
        {
            G = n * (y + 3.5) + Math.Sqrt(y);

            Console.WriteLine($"G = {G}");
        }
    }
}
