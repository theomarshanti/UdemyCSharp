using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Strings
    {
        void Demo()
        {
            var firstName = "Omar";
            string lastName = "Shanti";
            String c = "test";

            var fullname = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Omar" };
            var formattedNames = string.Join(",", names);

            var text = @"Hi John
                        Look into the following paths
                        c:/test/direct/fold1";
        }
    }
}
