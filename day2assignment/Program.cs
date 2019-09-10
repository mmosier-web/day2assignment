using System;

namespace day2assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of a square calculator");

            Console.WriteLine("Enter the length");

            int x = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter the width");

            int y=  Convert.ToInt32(Console.ReadLine()); ;

            int area = x * y;

            Console.WriteLine("area = " + area + " units squared");
        }
    }
}