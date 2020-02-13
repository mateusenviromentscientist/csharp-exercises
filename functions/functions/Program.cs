using System;

namespace functions
{
    class Program
    {
        public static int squared(int x)
        {
            int y = x * x;
            return y;
        }

        public static void printnumber(int number)
        {
            Console.WriteLine("number: " + number);       
        }


        public static Boolean isBigger(int first, int second)
        {
            Boolean temp = first > second;
            return temp;

        }
        static void Main(string[] args)
        {
            int temp = 10;
            int result = squared(temp);
            printnumber(temp);
            printnumber(result);
            Console.WriteLine(isBigger(10, 20));
            if(isBigger(20, 10)) ;
            {
                printnumber(result);
            }
        }
    }
}
