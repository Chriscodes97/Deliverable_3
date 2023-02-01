/*
  Program Author: Chris Parrado
  Date: 1/30/2023
  Decription: C# Application for basic iterative statements.
*/

using System;

namespace Deliverable_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int input = 0;
                string series = "";

                while (true)
                {
                    Console.Write("Enter an integer number between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.Write("Please specify the series type: Even or Odd ");
                    series = Console.ReadLine();

                    if (series == "Even" || series == "Odd")
                    {
                        break;
                    }
                }

                    if (series == "Odd")
                    {
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                        for (int i = 1; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    if (series == "Even")
                    {
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are:");
                        for (int i = 0; i <= input; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer number and series type.");
            }
        }
    }
}
