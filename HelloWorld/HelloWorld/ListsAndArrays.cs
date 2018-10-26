using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class ListsAndArrays
    {
        public void arrayDemo()
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 15, 6 };
            //Can be shortened to 
            var numbers2 = new[] { 3, 7, 9, 2, 15, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2); // Ckear the first 2 items (setting them to 0)

            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);

            //Reverse()
            Array.Reverse(numbers);

        }

        public void listDemo()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach(var num in numbers)
                Console.WriteLine(num);

            numbers.IndexOf(3); //Returns -1 if it doesn't exist
            numbers.LastIndexOf(3); //Starts in the end of the list

        }
    }
}
