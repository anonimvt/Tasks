using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberinput = Convert.ToInt32(Console.ReadLine());
            int divNumber = 2;

            if (numberinput > 1)
            {
                while (divNumber <= numberinput)
                {
                    Console.Write(divNumber + " ");
                    divNumber = divNumber + 2;
                }
            }
        }
    }
}
