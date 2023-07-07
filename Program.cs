using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an integer number between 5 and 15: ");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput >= 5 && userInput <= 15)
                {
                    int[] array = Method1(userInput);

                    Console.Write("The elements of the array are: ");
                    PrintArray(array);

                    int sum = Method2(array);
                    Console.WriteLine("The sum is: " + sum);
                }
                else
                {
                    Console.WriteLine("Invalid input. The number must be between 5 and 15.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }

            Console.ReadLine(); // Wait for user input before closing the console window
        }

        static int[] Method1(int length)
        {
            Random random = new Random();
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(10, 51); // Generate a random number between 10 and 50
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static int Method2(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
    }
}
