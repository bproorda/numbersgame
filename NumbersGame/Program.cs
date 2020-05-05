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
                Console.WriteLine("The elements of the array are: {0}", String.Join(", ", intialArray));
                Console.WriteLine($"Your array size: {intialArray.Length}");
                int theSum = GetSum(intialArray);
                Console.WriteLine($"The sum of the array is: {theSum}");
                int theProduct = GetProduct(intialArray, theSum);
                decimal theQuotient = GetQuotient(theProduct);
               
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
                int product = sum * array[randomNumber - 1];
                Console.WriteLine($"{sum} * {array[randomNumber - 1]} = {product}");
                return product;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Index out of range: {e}");
                return 0;
            }
        }
        public static decimal GetQuotient(int product)
        {
            try
            {
                Console.Write($"Enter a number to divide {product} by: ");
                decimal divisor = Convert.ToDecimal(Console.ReadLine());
                decimal dividend = Convert.ToDecimal(product);
                decimal answer = decimal.Divide(dividend, divisor);
                Console.WriteLine($"{dividend} / {divisor} = {answer}");
                return answer;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Cannot divide by zero: {e}");
                return 0;
            }
        }
    }
}
