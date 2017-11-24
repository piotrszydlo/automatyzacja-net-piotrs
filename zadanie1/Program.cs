using System;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Aby zamknąć aplikację, należy wpisać exit i nacisnąć klawisz enter");
            
            while (true)
            {
                string input = Console.ReadLine();
                Console.ReadKey();
                if (input == "exit")
                break;
            }
            Environment.Exit(-1);
        }
    }
}
