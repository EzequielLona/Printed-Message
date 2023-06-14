using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        bool exit = false;

        do
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter a number from 1 to 6:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && number >= 1 && number <= 6)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                }
            } while (true);

            switch (number)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Today we will learn about programming");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("How about taking a course in digital marketing?");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Today is a great day to start learning about design");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("What if we learn something about online business?");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Let's watch a couple of classes on audiovisual production");
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("It might be good to develop a soft skill on Platzi");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press 'S' to exit or any other key to continue.");
            char exitKey = Console.ReadKey().KeyChar;

            if (exitKey == 'S' || exitKey == 's')
            {
                exit = true;
            }
            else
            {
                Console.Clear();
            }
        } while (!exit);
    }
}
