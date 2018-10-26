using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Exercise3
    {
        public void demo()
        {
            exercise1();
            exercise2();
            exercise3();
            exercise4();
            exercise5();     
        }

        public void exercise1()
        {
            bool _continue = true;
            List<string> x = new List<string>();

            while (_continue)
            {
                Console.WriteLine("Ex1. Please enter a name");
                string user_input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(user_input)) {
                    x.Add(user_input);
                } else
                {
                    _continue = false;
                    if (x.Count > 2)
                    {
                        Console.WriteLine(string.Format("{0}, {1}, and {2} other friends liked your post", x[0],x[1],x.Count-2));
                    } else if(x.Count == 2) {
                        Console.WriteLine(string.Format("{0} and {1} liked your post", x[0], x[1]));
                    } else if (x.Count == 1) {
                        Console.WriteLine(string.Format("{0} liked your post", x[0]));
                    }
                }
            }
        }

        public void exercise2() {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            var rev_name = new char[name.Length];
            for(var i = 0; i<name.Length; i++)
            {
                rev_name[rev_name.Length-1-i] = name[i];
            }
            string reversed = new string(rev_name);
            Console.WriteLine("rev_name is: "+ reversed);
        }

        public void exercise3() {
            var listedNumbers = new List<int>();
            while (listedNumbers.Count < 5)
            {
                Console.WriteLine("Please enter " + (5 - listedNumbers.Count) + " more numbers");
                string entry = Console.ReadLine();
                int num = Convert.ToInt32(entry);
                if (!listedNumbers.Contains(num))
                {
                    listedNumbers.Add(num);
                }
            }
            listedNumbers.Sort();
            Console.WriteLine(String.Join(',', listedNumbers));
        }

        public void exercise4() {
            bool _cont = true;
            var numList = new List<int>();
            while (_cont)
            {
                Console.WriteLine("Please enter your input or Quit");
                string user_input = Console.ReadLine();
                if (user_input == "Quit") {
                    _cont = false;
                } else {
                    int num = Convert.ToInt32(user_input);
                    if(!numList.Contains(num)){
                        numList.Add(Convert.ToInt32(user_input));
                    }
                }
            }
            Console.WriteLine(String.Join(',',numList));
        }

        public void exercise5() {
            bool prompt = true;
            while (prompt)
            {
                Console.WriteLine("Please enter a comma-separated list of at least 5 numbers");
                string user_input = Console.ReadLine();
                String[] substrings = user_input.Split(",");
                var numbers = new List<int>();
                if (substrings.Length < 5)
                {
                    Console.WriteLine("Failure");
                } else {
                    prompt = false;
                    for(var i = 0; i<substrings.Length; i++)
                    {
                        numbers.Add(Convert.ToInt32(substrings[i]));
                    }
                    numbers.Sort();
                    Console.WriteLine("The 3 lowest are: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
                }
            }
        }
    }
}
