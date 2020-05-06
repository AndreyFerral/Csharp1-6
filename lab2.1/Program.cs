using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y = 0;
            double R = 2;
            Console.WriteLine("Введите значение X");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine(" |\t" + "x" + "\t |\t" + "y" + "\t | ");
            Console.WriteLine(" -------------------------------- ");

            if (x <= -5) y = 0;
            if (x > -5 && x <= -3) y = 1;
            if (x > -3 && x <= -1) y = -Math.Sqrt(R * R - (x + 1) * (x + 1));
            if (x > -1 && x <= 2) y = -2;
            if (x > 2 && x <= 5) y = x - 4;
            if (x > 5) y = 0;
            Console.WriteLine(" |\t" + x + "\t|\t" + y + "\t | ");
            Console.ReadLine();
        }
    }
}