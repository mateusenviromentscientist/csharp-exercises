using System;

namespace willie
{
    class Program
    {
        static void Main(string[] args)

        {
            int temp = 0;
            while (temp < 5)
            {
                if (temp > 3)
                {
                    break;
                }

                temp++;

            }
            Console.WriteLine(temp);
            int[] arr = { 10, 20, 30, 40 };
            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                i++;
            }
        }


    }

}    
    
