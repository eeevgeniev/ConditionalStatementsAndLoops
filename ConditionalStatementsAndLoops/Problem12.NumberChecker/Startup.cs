namespace Problem12.NumberChecker
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}