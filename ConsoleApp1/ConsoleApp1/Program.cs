using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ournumber;
            ournumber = 10;
            Console.WriteLine(ournumber);
            ournumber = 0;
            Console.WriteLine(ournumber);
            ournumber = 2 + 2;
            Console.WriteLine(ournumber);
            double deciamalnumber;
            deciamalnumber = 10.15;
            Console.WriteLine(deciamalnumber);
            int number = 5;

            char mycharacter = 'c';
            Console.WriteLine(mycharacter);
            
            string myname = "Mateus";

            Console.WriteLine(myname);
            int newvariable = ournumber - number;
            Console.WriteLine(newvariable);

            Boolean temp = true;
            Console.WriteLine(temp);

            Boolean tempo = (false && true);
            Console.WriteLine(tempo);
            Boolean result = true || tempo;
            Console.WriteLine(result);
            Boolean pedo = (false && false);
            Console.WriteLine(pedo);
            Boolean lara = true || (false && true);
            Console.WriteLine(lara);



        }
    }
}
