using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] winningNumbers = { 7, 13, 21, 42, 73, 99 };

            int[] userNumbers = new int[20];

            Console.WriteLine("LOTTERY GAME - Enter your lucky numbers (1-99)");
            Console.WriteLine($"Winning numbers: {string.Join(", ", winningNumbers)}\n");

            for (int i = 0; i < 20; i++)
            {
                while (true)
                {
                    Console.Write($"User {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        if (number >= 1 && number <= 99)
                        {
                            userNumbers[i] = number;
                            break;
                        }
                        Console.WriteLine("Number must be between 1 and 99!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a whole number.");
                    }
                }
            }

            Console.WriteLine("\nRESULTS:");
            int totalWinners = 0;

            for (int i = 0; i < 20; i++)
            {
                if (Array.IndexOf(winningNumbers, userNumbers[i]) >= 0)
                {
                    Console.WriteLine($"CONGRATULATIONS! User {i + 1} won with number {userNumbers[i]}!");
                    totalWinners++;
                }
            }
            if (totalWinners == 0)
            {
                Console.WriteLine("Sorry, no winners this time!");
            }
        }
    }
}
            
