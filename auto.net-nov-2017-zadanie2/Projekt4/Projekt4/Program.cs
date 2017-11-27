using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y = a * (x * x) + b  * y + c");
            Console.Write("podaj wartośc a = ");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj wartośc b = ");
            var b = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj wartośc c = ");
            var c = Convert.ToDouble(Console.ReadLine());

            Calculate(a, b, c);

            Console.WriteLine("Brawo! Czwarte zadanie zrobione :)");
            Console.WriteLine("Naciśnij jakikolwiek klawisz aby zakończyć...");
            Console.ReadKey();
        }

        private static void Calculate(double a, double b, double c)
        {
            double x1 = 0;
            double x2 = 0;

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                Console.WriteLine("Funkcja ma dwa miejsca zerowe");
                x1 = (- b + Math.Sqrt(delta)) / 2 * a;
                x2 = (- b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Miejsce zerowe x1 wynosi: " + x1);
                Console.WriteLine("Miejsce zerowe x2 wynosi: " + x2);
            }
            else if (delta == 0)
                {
                    Console.WriteLine("Funkcja ma jedno miejsce zerowe");
                    x1 = - b / 2 * a;
                    Console.WriteLine("Miejsce zerowe x1 wynosi: " + x1);
                }
            else
                {
                    Console.WriteLine("Funkcja nie posiada miejsc zerowych");
                }         
        }
    }
}