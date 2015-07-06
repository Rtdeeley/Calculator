using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input calculation: "); //Tell User what to do
            string var = Console.ReadLine(); // Awaits input from user and will then store the string. ex: 1+2 is stored
            double var1 = double.Parse(var); // Must parse out numbers and operator
                                             // Method to calculate the parsed numbers
            Console.Write(var1); // Display the answers

            Console.ReadLine(); //View program without closing

        }
    }
}
