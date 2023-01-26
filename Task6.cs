using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int number = Convert.ToInt32(Console.ReadLine());
            int devint = number % 2;

            if (devint == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }

        }
    }
}
