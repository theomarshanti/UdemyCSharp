using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld.Math;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail=1,
        RegisteredAirMail=2,
        Express=3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person();
            John.FirstName = "John";
            John.LastName = "Smith";
            John.Introduce();

            Calculator myCal = new Calculator();
            Console.WriteLine(myCal.Add(1, 6));

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString()); //This even brings back Express

            //Convert a string to an Enum:
            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            switch(shippingMethod)
            {
                case ShippingMethod.Express:
                    Console.WriteLine("Test");
                    break;
                default:
                    break;
            }

            //Exercise1 c = new Exercise1();
            //c.demo();
            //Exercise3 c = new Exercise3();
            //c.demo();
            Exercises4 c = new Exercises4();
            c.demo();
        }

        public void DataTime()
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }

        public void TimeSpans()
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan2 = new TimeSpan(1, 0, 0);
            var timeSpan3 = TimeSpan.FromHours(1);

            //If you subtract 2 day time objects, you get a time span.
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Can modify their values with built-in methods:
            timeSpan.Add(TimeSpan.FromMinutes(8));
            timeSpan.Subtract(TimeSpan.FromMinutes(2));

            //ToString
            Console.WriteLine("To String" + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }

        public void Strings()
        {
            //Strings here are immutable, so all of the internal methods we call create a new string
            // rather than updating the existing one.

            var fullName = "Omar ";
            Console.WriteLine("Trim: {0}", fullName.Trim());
            Console.WriteLine("W/o Trim: {0}", fullName);

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);

            string[] names = fullName.Split(' ');
            Console.WriteLine("1st name: " + names[0]);
            Console.WriteLine("2nd name: " + names[1]);

            fullName.Replace("Omar", "Abou 3meir");
        }

        public void SummarizeText()
        {
            var sentence = "asdnjksanfjskanbfsJKABgiuasgdgbdskjgbdszlkjgbsjkdg";
            const int maxLength = 20;

            if (sentence.Length < maxLength)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if(totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                string summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary) ;
            }
            
        }

        public void StringBuilderDemo()
        {
            var builder = new StringBuilder();
            builder
                .Append('-', 10) //Add this and repeat the process 10x
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            Console.WriteLine(builder);

            builder.Replace('-', '+');
            Console.WriteLine(builder);

            builder.Remove(0, 10);
            Console.WriteLine(builder);

            builder.Insert(0, new string('-', 10));
        }
    }
}
