using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Exercises4
    {
        public void demo()
        {
            //exercise1();
            //exercise2();
            //exercise3();
            //exercise4();
            exercise5();
        }

        void exercise1()
        {
            Console.WriteLine("Please enter some numbers with hyphens in between");
            string userinput = Console.ReadLine().Trim();
            string[] numList = userinput.Split('-');
            int[] numsSeen = new int[numList.Length];

            bool decreasing = false;
            bool increasing = false;

            for(var i =0; i<numList.Length; i++)
            {
                int num = Convert.ToInt32(numList[i]);

                if (i != 0)
                {
                    if ( (numsSeen[i - 1] + 1) == num)
                    {
                        increasing = true;
                        if (decreasing == true)
                        {
                            Console.WriteLine("Not consecutive. ");
                            return;
                        }
                    } else if ((numsSeen[i - 1] - 1) == num)
                    {
                        decreasing = true;
                        if (increasing == true)
                        {
                            Console.WriteLine("Not consecutive. ");
                            return;
                        }
                    } else
                    {
                        Console.WriteLine("Not consecutive. ");
                        return;
                    }
                }
                numsSeen[i] = num;
            }

            if(decreasing && increasing)
            {
                Console.WriteLine("PROBLEM");
            } else if (decreasing)
            {
                Console.WriteLine("Decreasing");
            } else if (increasing)
            {
                Console.WriteLine("Increasing");
            }
        }

        void exercise2()
        {
            Console.WriteLine("Ex2 - Please enter some numbers with hyphens in between");
            string userinput = Console.ReadLine().Trim();
            if (String.IsNullOrEmpty(userinput)) { Console.WriteLine("You entered nothing"); return; }
            else
            {
                string[] numbers = userinput.Split('-');
                var nums = new List<string>();
                for(var i = 0; i<numbers.Length; i++)
                {
                    if (nums.Contains(numbers[i])) {
                        Console.WriteLine("Duplicate!");
                        return;
                    } else
                    {
                        nums.Add(numbers[i]);
                    }
                }
                Console.WriteLine( "No duplicates found for: "+ String.Join(",", nums));
            }

        }

        void exercise3()
        {
            Console.WriteLine("Please enter a time in XX:YY format" );
            string userInput = Console.ReadLine();
            int index = userInput.IndexOf(":");
            if (index < 0)
            {
                return;
            }
            string[] hm = userInput.Split(":");
            int hour = Convert.ToInt32(hm[0]);
            int min = Convert.ToInt32(hm[1]);

            if( (hour>=0) && (hour<24) && (min >= 0) && (min<60))
            {
                Console.WriteLine("OK");
            } else
            {
                Console.WriteLine("Invalid Time");
            }
        }

        void exercise4()
        {
            Console.WriteLine("Please enter the word from which we will derive your PascalCase Var name");
            string userInput = Console.ReadLine();
            string[] wordsList = userInput.Split(" ");
            string varName = "";
            foreach(string word in wordsList)
            {
                string lowerword = word.ToLower();
                string upperword = word.ToUpper();
                string finalword = lowerword[0] + upperword.Substring(1);
                varName = varName + finalword;
            }
            Console.WriteLine("varName is "+varName);
        }

        void exercise5()
        {
            Console.WriteLine("Please enter a word");
            string userInput = Console.ReadLine();
            int count = 0;
            var vowelList = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            foreach(char c in userInput)
            {
               if (vowelList.Contains(c)) {
                    count++;
                }
            }
            Console.WriteLine("The # is: "+ count);
        }

    }
}
