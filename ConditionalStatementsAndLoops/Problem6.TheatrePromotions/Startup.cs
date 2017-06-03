namespace Problem6.TheatrePromotions
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            string message = GetMessage(age, dayType);

            Console.WriteLine(message);
        }

        private static string GetMessage(int age, string dayType)
        {
            if (0 <= age && age <= 18)
            {
                switch (dayType)
                {
                    case "Weekday":
                        return $"{12}$";
                    case "Weekend":
                        return $"{15}$";
                    case "Holiday":
                        return $"{5}$";
                }
            }
            else if (18 < age && age <= 64)
            {
                switch (dayType)
                {
                    case "Weekday":
                        return $"{18}$";
                    case "Weekend":
                        return $"{20}$";
                    case "Holiday":
                        return $"{12}$";
                }
            }
            else if (64 < age && age <= 122)
            {
                switch (dayType)
                {
                    case "Weekday":
                        return $"{12}$";
                    case "Weekend":
                        return $"{15}$";
                    case "Holiday":
                        return $"{10}$";
                }
            }

            return "Error!";
        }
    }
}