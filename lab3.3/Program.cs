using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double E = 1e-5;

            int maxIteration = 1000;
            Console.WriteLine("Введите Xn, Xk, dx");
            double.TryParse(Console.ReadLine(), out double Xn);
            double.TryParse(Console.ReadLine(), out double Xk);
            double.TryParse(Console.ReadLine(), out double dx);

            Console.WriteLine("|x =\t | Ответ\t| Проверка\t | Кол-во просум. элем");
            Console.WriteLine("---------------------------------------------------------");

            for (double x = Xn; x < Xk; x += dx) {
                bool Result = true;
                int n;
                double check = Math.Log(x);
                double sum;

                if (x < E && x > 0) x = 0;
                double a = (x - 1) / x;
                sum = a;
                for (n = 0; Math.Abs(a) >= E; n++) {
                    a *= ((x - 1) * (n + 1)) / ((n + 2) * x);
                    sum += a;
                    if (n == maxIteration) {
                        Result = false;
                        break;
                    }
                }

                if (Result) {
                    Console.WriteLine("|" + Math.Round(x, 5) + "\t | " + Math.Round(sum, 5) + " \t| " + Math.Round(check, 5) + "\t | " + n);
                }
                else {
                    Console.WriteLine("|" + Math.Round(x, 5) + "\t | Ряд расход! \t| " + Math.Round(check, 5) + "\t");
                }
            }
            Console.ReadLine();
        }
    }
}