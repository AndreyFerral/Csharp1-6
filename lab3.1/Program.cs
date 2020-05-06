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
            double Xn, Xk, dx, x = 0, y = 0;
            double R = 2;
            Console.WriteLine("Введите значение Xn, Xk, dx");
            double.TryParse(Console.ReadLine(), out Xn);
            double.TryParse(Console.ReadLine(), out Xk);
            double.TryParse(Console.ReadLine(), out dx);
            Console.WriteLine(" |\t" + "x" + "\t |\t" + "y" + "\t | ");
            Console.WriteLine(" -------------------------------- ");

            for (x = Xn; x < Xk; x += dx)
            {
                if (x <= -5) y = 0;
                if (x > -5 && x <= -3) y = 1;
                if (x > -3 && x <= -1) y = -Math.Sqrt(R * R - (x + 1) * (x + 1));
                if (x > -1 && x <= 2) y = -2;
                if (x > 2 && x <= 5) y = x - 4;
                if (x > 5) y = 0;
                Console.WriteLine(" |\t" + x + "\t|\t" + y + "\t | ");
            }
            Console.ReadLine();
        }
    }
}