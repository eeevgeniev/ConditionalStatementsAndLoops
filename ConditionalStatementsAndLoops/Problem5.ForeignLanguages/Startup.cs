﻿namespace Problem5.ForeignLanguages
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}