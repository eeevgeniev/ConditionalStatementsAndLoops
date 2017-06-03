namespace Problem8.SumOfOddNumbers
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= count; i++)
            {
                int oddNumber = i * 2 - 1;

                Console.WriteLine(oddNumber);

                sum += oddNumber;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}