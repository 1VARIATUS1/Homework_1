using System;
using System.Security.Cryptography.X509Certificates;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} !");

            Console.WriteLine(name + ", choose any num1:");
            string num1 = Console.ReadLine();
            int a = int.Parse(num1);
            Console.WriteLine(name + ", choose any num2:");
            string num2 = Console.ReadLine();
            int b = int.Parse(num2);
            Console.WriteLine(name + ", choose any num3:");
            string num3 = Console.ReadLine();
            int c = int.Parse(num3);
            double d;
            d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("Дискриминант меньше ноля, корней нет");
            }
            if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Есть ровно один корень x=" + x);
            }
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Корней будет два: х1=" + x1 + "; x2=" + x2);
            }
            Console.WriteLine("А теперь введите длину двух катетов, первый:");
            double a_leg = double.Parse(Console.ReadLine());
            Console.WriteLine("Второй:");
            double b_leg = double.Parse(Console.ReadLine());
            double c_hyp = Math.Sqrt(Math.Pow(a_leg, 2) + Math.Pow(b_leg,2));
            Console.WriteLine($"Длина гипотенузы рaвна {c_hyp} см");

            double α = Math.Tan(a_leg / b_leg)*180/Math.PI; 
            double β = 180 - 90 - α;
            double γ = 90;
            Console.WriteLine($"Углы вашего прямоугольного треугольника {α}, {β}, {γ}");

            Console.ReadKey();


        }
    }
}
