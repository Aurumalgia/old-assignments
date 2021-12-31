using static System.Console;
using System;
namespace Assingnment1B
{
    class MakeChange
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the amount to make change: ");
            string userIn = ReadLine();
            int total = System.Convert.ToInt32(userIn);
            int hundreds = total / 100;
            total = total % 100;
            int twenties = total / 20;
            total = total % 20;
            int tens = total / 10;
            total = total % 10;
            int fives = total / 5;
            total = total % 5;
            int ones = total;
            int check = ones + 5 * fives + 10 * tens + 20 * twenties + 100 * hundreds;
            WriteLine();
            WriteLine("100s: " + hundreds + "\n");
            WriteLine("20s: " + twenties + "\n");
            WriteLine("10s: " + tens + "\n");
            WriteLine("5s: " + fives + "\n");
            WriteLine("1s:" + ones + "\n");
            WriteLine("Check Total: " + check);
           
            ReadKey();
        }
    }
}
