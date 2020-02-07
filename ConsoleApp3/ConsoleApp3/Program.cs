using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int swiched = 5;
            int result = 0;
            switch (swiched)
            {
                case 1:
                    result = 10;
                    break;
                case 3:
                    result = 30;
                    break;
                case 5:
                    result = 50;
                    break;
                default:
                    result = 100;
                    break;








            }
            if(1 == swiched)
            {
                result = 15;
            }else if(3 == swiched)
            {
                result = 30;
            }
            Console.WriteLine(result);
        } 
          
            
             
          
    }
}
