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
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Введите x, y, r: ");
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                double.TryParse(Console.ReadLine(), out double r);
                if (Math.Pow((x + r), 2) + Math.Pow((y), 2) <= Math.Pow((r), 2) && y >= 0 && x <= 0 || Math.Pow((x - r), 2) + Math.Pow((y), 2) <= Math.Pow((r), 2) && x >= 0 && y <= 0)
                    Console.WriteLine("Точка попадает в область\n");
                else Console.WriteLine("Точка не попадает в область\n");
            }
            Console.ReadLine();
        }
    }
}