using System;

namespace f1
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "Whatever we want";
            string val2 = "whatever";
            Console.WriteLine(val);

            Console.WriteLine(val.ToUpper());

            Console.WriteLine(val);

            Console.WriteLine(val.ToLower().Contains("whatever"));

            Console.WriteLine(val.LastIndexOf('t'));
            Console.WriteLine(val.Length);

            Console.WriteLine(val.Replace('w', 'j'));

            Console.WriteLine(val.Remove(0,3));
            Console.WriteLine(val.Remove(2, val.Length - 4));

            Console.WriteLine(val.Substring(3,5));
            Console.WriteLine(val.StartsWith("Wha"));
            Console.WriteLine(val.EndsWith("t"));

            string url = "         www. google.com/pedo/de/lara"        ;
            string[] part = url.Split('/');
            Console.WriteLine(part[0]);

            Console.WriteLine(url);
            Console.WriteLine(url.Trim());


        }
    }
}
