namespace Problem10.MultiplicationTableTwo
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    int product = integer * i;

                    Console.WriteLine($"{integer} X {i} = {product}");
                }
            }
            else
            {
                int product = integer * multiplier;

                Console.WriteLine($"{integer} X {multiplier} = {product}");
            }
        }
    }
}