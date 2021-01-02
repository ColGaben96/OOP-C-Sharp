using System;

namespace FUNPROHelloWorld
{
    class TempVariables
    {
        public TempVariables()
        {
            var myInt = 1;
            var myFloat = 3.2f;
            var myDouble = 3.44444;
            var myChar = 'a';
            var myString = "aaa";

            Console.WriteLine("My Variables: \n" +
                $"int: {myInt} \n" +
                $"float: {myFloat} \n" +
                $"double: '{myDouble} \n" +
                $"char: {myChar}\n" +
                $"string: {myString}");

        }
    }
}
