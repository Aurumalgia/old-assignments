using System;

namespace TaskB
{
    class MonthNames
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
            Postember
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Month Number");
            Console.WriteLine((Months) Convert.ToInt32(Console.ReadLine())-1);
            Console.ReadKey();
        }
    }
}

