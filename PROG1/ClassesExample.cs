using System;
using System.Collections.Generic;
using System.Text;

namespace PROG1
{
    class ClassesExample
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();
            Console.WriteLine(class1.toString());
            Console.WriteLine(class2.toString());
        }
    }

    class Class1
    {
        public string toString()
        {
            return "Hey! I'm Class 1";
        }
    }

    class Class2
    {
        public string toString()
        {
            return "Hey! I'm Class 2";
        }
    }
}
