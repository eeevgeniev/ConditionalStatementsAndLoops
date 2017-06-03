namespace Problem2.PassedOrFailed
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Startup
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3D)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
