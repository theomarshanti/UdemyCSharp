using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Exercise1
    {
        public void demo()
        {
            exercise1();
            exercise2();
            exercise3();
            exercise4();
        }
        void exercise1()
        {
            Console.WriteLine("Please enter a number: ");
            string q = Console.ReadLine();
            int q2 = int.Parse(q);

            if ((q2 > 10) || (q2 < 1))
            {
                Console.WriteLine("valid");
            }
        }

        void exercise2()
        {
            Console.WriteLine("Please enter your 1st number: ");
            string a = Console.ReadLine();
            int a2 = int.Parse(a);

            Console.WriteLine("Please enter your 2nd number: ");
            string b = Console.ReadLine();
            int b2 = int.Parse(b);

            Console.WriteLine("Your max value is :" + ((a2 > b2) ? a2 : b2));
        }

        void exercise3()
        {
            Console.WriteLine("Please enter your width: ");
            string a = Console.ReadLine();
            int a2 = int.Parse(a);

            Console.WriteLine("Please enter your height: ");
            string b = Console.ReadLine();
            int b2 = int.Parse(b);

            Console.WriteLine("Your picture is :" + ((a2 > b2) ? "Landscape" : "Portrait"));
        }

        void exercise4()
        {
            Console.WriteLine("Please enter your top speed: ");
            string a = Console.ReadLine();
            int a2 = int.Parse(a);

            Console.WriteLine("Please enter your cars speed: ");
            string b = Console.ReadLine();
            int b2 = int.Parse(b);

            if (a2 > b2)
            {
                Console.WriteLine("You're okay");
            }
            else
            {
                int demerit = (b2 - a2) / 5;
                Console.WriteLine("You have achieved " + demerit + " Demerit Points");
                if (demerit > 12)
                {
                    Console.WriteLine("Your license is suspended");
                }
            }
        }
    }
}
