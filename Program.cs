using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение a:");
            string a1 = Console.ReadLine();
            Console.WriteLine("Введите значение b:");
            string b1 = Console.ReadLine();
            Console.WriteLine("Введите значение c:");
            string c1 = Console.ReadLine();
            Convert.ToDouble(a1);
            Double a = Convert.ToDouble(a1);
            Convert.ToDouble(b1);
            Double b = Convert.ToDouble(b1);
            Convert.ToDouble(c1);
            Double c = Convert.ToDouble(c1);
            Math.Pow(b, 2);
            double bkv = Math.Pow(b, 2);
            double d = bkv - (4 * a * c);
            Math.Sqrt(d);
            double qd = Math.Sqrt(d);
            double x1 = (-b + qd) / (2 * a);
            double x2 = (-b - qd) /( 2 * a);
             
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Нет решений");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(-c / b);
                    Console.ReadKey();
                }
            }
            else if (d < 0)
            {
                Console.WriteLine("Нет решений");
                Console.ReadKey();
            }
            else if (c == 0)
            {
                Console.WriteLine(-b / a);
                Console.WriteLine(c);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(x1);
                Console.WriteLine(x2);
                Console.ReadKey();
            }
        }
    }
}

     # Equation
