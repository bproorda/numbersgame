using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                StartSequence();
            }
            catch (Exception)
            {
                Console.WriteLine("Danger, Will Robinson!");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("The program is finished. Goodbye");
                Console.ReadLine();
            }
        }
        public static void StartSequence()
        {
            try
            {
                Console.WriteLine("Welcome to my game! Lets do some math!");
                Console.WriteLine("Please enter a number greater than zero.");
                int userSize = Convert.ToInt32(Console.ReadLine());
                int[] intialArray = new int[userSize];
                Populate(intialArray);
                Console.WriteLine("[{0}]", String.Join(", ", intialArray));
                int theSum = GetSum(intialArray);
                Console.WriteLine($"The sum is: {theSum}");
                int theProduct = GetProduct(intialArray, theSum);
                Console.WriteLine($"The product is: {theProduct}");
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Invalid format: {e}");
                Console.ReadLine();
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Overflow error: {e}");
                Console.ReadLine();
            }
        }

        public static int[] Populate(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Please enter a number, {i + 1} of {length}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        public static int GetSum(int[] array)
        {
            int sum = 0;
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }

        public static int GetProduct(int[] array, int sum)
        {
            try
            {
                int length = array.Length;
                Console.Write($"Enter a number between 1 and {length}: ");
                int randomNumber = Convert.ToInt32(Console.ReadLine());
                int product = sum * array[randomNumber];
                return product;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Index out of range: {e}");
                return 0;
            }
        }
    }
}
