using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first number: ");
            int first = Int32.Parse (Console.ReadLine());
            Console.WriteLine("second number: ");
            int second = Int32.Parse(Console.ReadLine());
            int result = first + second;
            Console.WriteLine(first + " + " + second + " = " + result);
            result = first - second;
            Console.WriteLine(first + " - " + second + " = " + result);
            result = first / second;
            Console.WriteLine(first + " / " + second + " = " + result);
            result = first * second;
            Console.WriteLine(first + " * " + second + " = " + result);


        }
    }
}
