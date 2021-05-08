using System;

namespace RefillMyGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            var glass = new Glass();

            Console.WriteLine("Enter a command ");
            var command = Console.ReadLine();
            

            while (command != "stop")
            {
                var splittedCommand = command.Split(' ');

                switch (splittedCommand[0])
                {
                    case "print":
                        Console.WriteLine($"This glass contains {glass.LiquidLevel}ml of liquid");
                        break;
                    case "drink":
                        glass.Drink(int.Parse(splittedCommand[1]));
                        break;


                }
                Console.WriteLine("Enter a command ");
                command = Console.ReadLine();
            }

            Console.WriteLine("Program terminated");
        }

    }
}
