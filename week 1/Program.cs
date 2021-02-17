using System;

namespace week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ResizableIntArray numbers = new ResizableIntArray();
            bool repeat = true;
            do
            {
                Console.WriteLine("Please enter an integer: ");
                string line = Console.ReadLine();
                if (line == "exit")
                {
                    repeat = false;
                }
                else
                {
                    try
                    {
                        int number = int.Parse(line);
                        Console.WriteLine("The integer that you entered was: " + number);
                        numbers.Add(number);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That was not an integer!");
                    }
                }
            }
            while (repeat);
            numbers.WriteContentsToConsole();
            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("Max: " + numbers.Max());
            Console.WriteLine("Min: " + numbers.Min());
            numbers.Ascending();
            numbers.Descending();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
