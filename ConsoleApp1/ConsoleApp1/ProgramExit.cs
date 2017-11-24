using System;

namespace zadanie1
{
    class ProgramExit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                Console.WriteLine("Aby zamknąć aplikację, należy wpisać exit i nacisnąć klawisz enter");
                string input = Console.ReadLine();
                Console.ReadKey();
                if (input == "exit")
                    break;
            }
            Environment.Exit(-1);
        }
    }
}
