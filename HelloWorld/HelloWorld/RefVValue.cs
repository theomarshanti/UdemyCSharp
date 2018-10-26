using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class TestPerson
    {
        public int Age;
    }

    class RefVValue
    {
        void demo()
        {
            var a = 10;
            var b = a;
            b++;
            //What is the value of a? 10. Because integers are value-types.
            //Only a copy of the value is stored; not the memory address!
            //A brand new memory location is created for b with the val of a copied.

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            //Array 1 points and referneces an object on the heap.
            //Runtime then creates a new var on the Stack that holds the address of the array 
            // stored on the heap
            //So changing array2 will change array1

            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            //Number doens't change.

            var person = new TestPerson() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }
           
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(TestPerson person)
        {
            person.Age += 10;
        }
    }
}
