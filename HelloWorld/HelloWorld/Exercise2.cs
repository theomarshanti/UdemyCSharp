using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Exercise2
    {
        public void exercise1()
        {
            int count = 0;
            for(int i = 0; i<100; i++)
            {
                if (i % 3==0) { count++; }
            }
            Console.WriteLine(count);
        }

        public void exercise2()
        {
            bool myBool = true;
            int total = 0;
            while (myBool)
            {
                var userInput = Console.ReadLine();
                if (userInput == "ok")
                {
                    myBool = false;
                    Console.WriteLine("total is: " + total);
                    break;
                }
                else
                {
                    total += int.Parse(userInput);
                }
            }
        }

        public void exercise3()
        {
            var userInput = Console.ReadLine();
            int userNum = int.Parse(userInput);
            int total = 1;
            for(var i = 1; i<=userNum; i++)
            {
                total *= i;
            }
            Console.WriteLine("total = ", total);
        }

        public void exercise4()
        {
            Random c = new Random();
            int rand = c.Next(10);
            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine("Please enter your " + i + "th guess");
                string d = Console.ReadLine();
                if(rand == int.Parse(d))
                {
                    Console.WriteLine("Success!");
                    break;
                }
            }
        }

        void exercise5()
        {
            Console.WriteLine("Please enter your digits");
            string d = Console.ReadLine();
            int max = 0;
            int prev = 0;
            foreach(var char_ in d){
                if (char_ == ',') { prev = 0;  }
                else { if (char_> max) { max = char_; } }
            }
        }
    }
}
