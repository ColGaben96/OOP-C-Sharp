using System;
using System.Collections.Generic;
using System.Text;

namespace FUNPROHelloWorld
{
    class Controller
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nRunning Hello World");
            HelloMain hello = new HelloMain();
            Console.WriteLine("\nRunning Temporary Variables");
            TempVariables temp = new TempVariables();
            Console.WriteLine("\nRunning Flow Control 1");
            FlowControl1 flow1 = new FlowControl1();
            Console.WriteLine("\nRunning Flow Control 2");
            FlowControl2 flow2 = new FlowControl2();
            Console.WriteLine("\nRunning Flow Control 3");
            FlowControl3 flow3 = new FlowControl3();
        }
    }
}
