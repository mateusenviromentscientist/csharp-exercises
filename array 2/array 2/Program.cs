using System;

namespace array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 10, 20, 50, 18, 22 };
            Console.WriteLine("number on index 0 : " + ages[0]);
            int onindex2 = ages[2];
            Console.WriteLine("age on index 2: " + onindex2);
            ages[2] = ages[2] + 1;
            Console.WriteLine("age on index 2: " + ages[2]);
            Console.WriteLine("onindex2 :" + onindex2);

            string[] names = { "Adam", "Ava", "Paul", "Emilly" };
            string name = names[1];
            names[1] = "Peter";
            Console.WriteLine(name);
            Console.WriteLine(names[1]);
        }
    }
}
