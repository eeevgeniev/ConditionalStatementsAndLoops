namespace Problem9.MultiplicationTable
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int integer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int product = integer * i;

                Console.WriteLine($"{integer} X {i} = {product}");
            }
        }
    }
}