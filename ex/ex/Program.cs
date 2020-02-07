using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 20;
            int temp = 10;
            char op = '*';

            switch (op)
            {
                case '+':
                    result = result + temp;
                    break;
                case '*':
                    result = result * temp;
                    break;
                case '-':
                    result = result - temp;
                    break;
                default:
                    result = 0;
                    break;
            
            }
            Console.WriteLine(result);
        }
    }
}
