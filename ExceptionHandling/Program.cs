﻿using System;


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter some line of symbols");

            string line = Console.ReadLine();

            try
            {
                WriteFirstSymbol(line);
            }
            catch (EmptyLineException ex)
            {
                Console.WriteLine($"An exception has occurred! {ex.Message}");
            }
            Console.ReadKey();

        }

        public static void WriteFirstSymbol(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                throw new EmptyLineException("Nothing were entered");
            }
            else
            {
                Console.WriteLine(line[0]);
            }
        }
    }
}
