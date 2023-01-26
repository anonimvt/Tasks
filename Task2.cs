using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(number1 > number2) 
            {
                Console.WriteLine($"max = {number1}");
                Console.WriteLine($"min = {number2}");
            }
            else
            {
                Console.WriteLine($"max = {number2}");
                Console.WriteLine($"min = {number1}");
            }
        }
    }
}
