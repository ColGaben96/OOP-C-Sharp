using System;
using System.Collections.Generic;
using System.Text;

namespace FUNPROHelloWorld
{
    class FlowControl1
    {
        public FlowControl1()
        {
            Console.Write("\nEnter your name: ");
            var name = Console.ReadLine();
            if (name.Equals("Gaben"))
            {
                Console.WriteLine("Hey Gabe!");
            } else if (name.Equals("Luis")) 
            {
                Console.WriteLine("Hi Honey!");
            } else {
                Console.WriteLine("Excuse me. Who are you?");
            }
        }
    }
}
