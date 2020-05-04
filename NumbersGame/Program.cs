using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartSequence();
        }
        public static void StartSequence()
        {
            Console.WriteLine("Welcome to my game! Lets do some math!");
            Console.WriteLine("Please enter a number greater than zero.");
            int userSize = Convert.ToInt32(Console.ReadLine());
            int[] intialArray = new int[userSize];
            Populate(intialArray);
            Console.WriteLine("[{0}]", String.Join(", ", intialArray));
            Console.ReadLine();
        }

        public static int[] Populate(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Please enter a number, {(i +1)} of {length}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }
    }
}
