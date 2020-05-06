using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double a, b;
            Console.WriteLine("Введите x");
            double.TryParse(Console.ReadLine(), out x);
            a = (Math.Sqrt(Math.Pow(3 * x + 2, 2) - 24 * x)) / (3 * Math.Sqrt(x) - (2 / Math.Sqrt(x)));
            b = -(Math.Sqrt(x));
            Console.WriteLine("Первая переменная: " + a);
            Console.WriteLine("Вторая переменная: " + b);
            Console.ReadKey();
        }
    }
}