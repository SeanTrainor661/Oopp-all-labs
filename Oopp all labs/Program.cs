using System;

namespace Oopp_all_labs
{
    class Program
    {
        static void expandArrayBy10(ref int[] numbers, int currentIndex)
        {
            int expandedNumberOfCells = currentIndex + 10;
            int[] expandedNumbers = new int[expandedNumberOfCells];
            for (int i = 0; i < currentIndex; i++)
            {
                expandedNumbers[i] = numbers[i];
            }
            numbers = expandedNumbers;
        }
        static void tryParse(int number, ref int[] numbers, ref int currentIndex)
        {
            Console.WriteLine("The integer that you entered was: " + number);
            numbers[currentIndex] = number;
            currentIndex++;
            if (currentIndex == numbers.Length)
            {
                expandArrayBy10(ref numbers, currentIndex);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int currentIndex = 0;
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
                        tryParse(number, ref numbers, ref currentIndex);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That was not an integer!");
                    }
                }
            }
            while (repeat);
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
