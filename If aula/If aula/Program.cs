using System;

namespace If_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggernumber = 10;
            int smallernumber = 1;
            var pessoa = new Mateus();
            Console.WriteLine(pessoa.informarIdade());
            Console.WriteLine("1 condition");
            if (biggernumber != smallernumber)
            {
                Console.WriteLine(biggernumber + "is not equal to" + smallernumber);
            }

            Console.WriteLine("2. condition");
            if (biggernumber == smallernumber)
            {
                Console.WriteLine(biggernumber + "is equal" + smallernumber);
            }
            else
            {
                Console.WriteLine("Else");
            }

            Console.WriteLine("3. condition");
            if (biggernumber > smallernumber)
            {
                Console.WriteLine(biggernumber + "is greather than" + smallernumber);
            }
            else if (biggernumber != smallernumber)
            {
                Console.WriteLine(biggernumber + "is not equal to" + smallernumber);
            }
            else
            {
                Console.WriteLine("else");
            }

            Console.WriteLine("4. condition");
            if (biggernumber < smallernumber)
            {
                Console.WriteLine("is greather than" + smallernumber);
            }

            if (biggernumber != smallernumber)
            {
                Console.WriteLine(biggernumber + "is not equal to" + smallernumber);
            }
            else
            {
                Console.WriteLine("Else");
            }

            Console.WriteLine("5. condition");
            if (biggernumber <= smallernumber)
            {
                Console.WriteLine("bigger is smaller");
            }
            else if (biggernumber == smallernumber)
            {
                Console.WriteLine("they are equal");
            }
            else if (biggernumber != smallernumber)
            {
                Console.WriteLine("they are not equal");
            }
            else if (biggernumber > smallernumber)
            {
                Console.WriteLine("bigger is greater");
            }

            Console.WriteLine("6.condition");
            if (biggernumber <= smallernumber)
            {
                Console.WriteLine("bigger is smaller");
            }
            if (biggernumber == smallernumber)
            {
                Console.WriteLine("they are equal");
            }
            if (biggernumber != smallernumber)
            {
                Console.WriteLine("they are not equal");
            }
            if (biggernumber > smallernumber)
            {
                Console.WriteLine("bigger is greater");
            }

            Console.WriteLine("7. condiotion");
            if ((biggernumber > smallernumber) && (biggernumber < smallernumber))
            {
                Console.WriteLine("first");
            }
            else if ((biggernumber > smallernumber) && (!(biggernumber < smallernumber)))
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("else");
            }

            Console.WriteLine("8. condiotion");
            if ((biggernumber > smallernumber) || (biggernumber < smallernumber))
            {
                Console.WriteLine("first");
            }
            else if ((biggernumber > smallernumber) || (!(biggernumber < smallernumber)))
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("else");
            }

        }
    }
}