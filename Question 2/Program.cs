using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter an integer number between 1 and 9 (or type 'exit' to quit): ");
                string input = Console.ReadLine();

                // Checks if the user wants to exit the program
                if (input.ToLower() == "exit")
                {
                    break;
                }

                // Parse the input to an integer
                if (int.TryParse(input, out int number))
                {
                    // Check if the number is in the valid range
                    if (number >= 1 && number <= 3)
                    {
                        number *= 10;
                        Console.WriteLine($"Number after multiplication by 10: {number}");
                    }
                    else if (number >= 4 && number <= 6)
                    {
                        number /= 2;
                        Console.WriteLine($"Number after division by 2: {number}");
                    }
                    else if (number >= 7 && number <= 9)
                    {
                        number %= 10;
                        Console.WriteLine($"Number after modulus operation: {number}");
                    }
                    else
                    {
                        // Number is out of the valid range
                        Console.WriteLine("Error: Number is out of range. Please enter a number between 1 and 9.");
                    }
                }
                else
                {
                    // Input was not a valid integer
                    Console.WriteLine("Invalid input. Please enter a valid integer number.");
                }
            }

           
        }
    }
}
