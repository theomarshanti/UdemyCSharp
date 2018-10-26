using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class DemoCodeContainer
    {
        public void basicCode()
        {
            byte number = 2;
            Console.WriteLine(number);
            Console.WriteLine();

            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //string firstName = "Omar";
            //bool isWorking = true | false;

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //Format string

            //const float Pi = 3.14f;
            // Pi = 1f; 
            try
            {
                var number2 = "1234";
                byte b = Convert.ToByte(number2);
                string str = "true";
                bool b2 = Convert.ToBoolean(str);
                //Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("number couldnt be convered to byte");
                throw;
            }
        }

        public void iterations()
        {
            for(var j = 0; j<10; j++)
            {

            }

            var numbers = new int[3] { 0, 1, 2 };
            foreach( var number in numbers)
            {

            }

            int i = 0;
            while (i < 10)
            {
                i++;
            }

            do
            {
                i++;
            } while (i < 10);
        }

    }

}
