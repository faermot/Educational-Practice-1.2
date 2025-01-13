using ConsoleApp20.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №1.1");
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание (1-30): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №1");

                            double t, l;

                            Console.Write("Введите значение - t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - l: ");
                            l = Convert.ToDouble(Console.ReadLine());

                            Task1 task1 = new Task1(t, l);
                            task1.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №2");

                            double p, y, e;

                            Console.Write("Введите значение - p: ");
                            p = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Task2 task2 = new Task2(p, y, e);
                            task2.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №3");


                            double n, y;

                            Console.Write("Введите значение - n: ");
                            n = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task3 task3 = new Task3(n, y);
                            task3.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "4":
                        {

                            Console.Clear();
                            Console.WriteLine("Задание №4");


                            double a, t;

                            Console.Write("Введите значение - a: ");
                            a = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Task4 task4 = new Task4(a, t);
                            task4.PrintSolution();

                            Console.ReadKey();

                        }

                        break;

                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №5");

                            double  x;

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Task5 task5 = new Task5(x);
                            task5.PrintSolution();

                            Console.ReadKey();
                        }

                        break;

                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №6");

                            double y, e, x;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());


                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Task6 task6 = new Task6(y, e, x);
                            task6.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "7":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №7");

                            double m;

                            Console.Write("Введите значение - m: ");
                            m = Convert.ToDouble(Console.ReadLine());

                            Task7 task7 = new Task7(m);
                            task7.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "8":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №8");

                            double y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task8 task8 = new Task8(y);
                            task8.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "9":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №9");

                            double y, x;


                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());


                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Task9 task9 = new Task9(y, x);
                            task9.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "10":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №10");

                            double e, x, k, y;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task10 task10 = new Task10(e, x, k, y);
                            task10.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "11":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №11");

                            double y, x;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Task11 task11 = new Task11(y, x);
                            task11.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "12":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №12");

                            double t, x;


                            Console.Write("Введите значение - t: ");
                            t = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Task12 task12 = new Task12(t, x);
                            task12.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "13":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №13");

                            double y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task13 task13 = new Task13(y);
                            task13.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "14":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №14");

                            double y, e, x;


                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Task14 task14 = new Task14(y, e, x);
                            task14.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "15":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №15");

                            double y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task15 task15 = new Task15(y);
                            task15.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "16":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №16");

                            double y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task16 task16 = new Task16(y);
                            task16.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "17":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №17");

                            double y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task17 task17 = new Task17(y);
                            task17.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "18":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №18");

                            double y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task18 task18 = new Task18(y);
                            task18.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "19":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №19");

                            double n, y, g;

                            Console.Write("Введите значение - n: ");
                            n = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - g: ");
                            g = Convert.ToDouble(Console.ReadLine());

                            Task19 task19 = new Task19(n, y, g);
                            task19.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "20":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №20");

                            double e, k, y, x;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - k: ");
                            k = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Task20 task20 = new Task20(e, k, y, x);
                            task20.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "21":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №21");

                            double e, y, h;


                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            Task21 task21 = new Task21(e, y, h);
                            task21.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "22":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №22");

                            double u, y, x;

                            Console.Write("Введите значение - u: ");
                            u = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Task22 task22 = new Task22(u, y, x);
                            task22.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "23":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №23");

                            double e, f, y;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - f: ");
                            f = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task23 task23 = new Task23(e, f, y);
                            task23.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "24":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №24");

                            double y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task24 task24 = new Task24(y);
                            task24.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "25":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №25");

                            double e, y, f;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - f: ");
                            f = Convert.ToDouble(Console.ReadLine());

                            Task25 task25 = new Task25(e, y, f);
                            task25.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "26":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №26");

                            double p;

                            Console.Write("Введите значение - p: ");
                            p = Convert.ToDouble(Console.ReadLine());

                            Task26 task26 = new Task26(p);
                            task26.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "27":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №27");

                            double v, e, y, x;

                            Console.Write("Введите значение - v: ");
                            v = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - x: ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Task27 task27 = new Task27(v, e, y, x);
                            task27.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "28":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №28");

                            double e, y, h;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - h: ");
                            h = Convert.ToDouble(Console.ReadLine());

                            Task28 task28 = new Task28(e, y, h);
                            task28.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "29":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №29");

                            double y;

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Task29 task29 = new Task29(y);
                            task29.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    case "30":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №30");

                            double e, y, r;

                            Console.Write("Введите значение - e: ");
                            e = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - y: ");
                            y = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите значение - r: ");
                            r = Convert.ToDouble(Console.ReadLine());

                            Task30 task30 = new Task30(e, y, r);
                            task30.PrintSolution();

                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("Выберите корректное задание!");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
