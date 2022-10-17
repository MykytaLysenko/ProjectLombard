using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosze wybrać :");
            Console.WriteLine("1. Zalożyc biżuterie");
            Console.WriteLine("2. Wykupic biżuterie");
            ConsoleKey key = GetButton();
            Console.Clear();

            if (key == ConsoleKey.D1)
            {
                Console.WriteLine("Obrales 1");
            }
            else if (key == ConsoleKey.D2)
            {
                Console.WriteLine("Obrales 2");
            }

            Console.ReadKey();
            
        }

        public static ConsoleKey GetButton()
        {
            var but = Console.ReadKey().Key;

            return but;
        }

        
    }

    
}
