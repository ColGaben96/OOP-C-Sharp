using System;
using System.Collections.Generic;
using System.Text;

namespace FUNPROHelloWorld
{
    class FlowControl2
    {
       public FlowControl2()
        {
            Console.WriteLine("\nPrinting first 10 numbers");
            for(int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + ", ");
            }
            Console.WriteLine("\nPrinting last 3 numbers");
            for(int i = 10; i > (10-3); i--)
            {
                Console.Write(i - 1+ ",");
            }
            try
            {
                Console.Write("\n1 + 1 = ");
                int ans = int.Parse(Console.ReadLine());
                while(ans != 2)
                {
                    Console.WriteLine("You rubbish!");
                }
                Console.WriteLine("Very good!");
            } catch (FormatException)
            {
                Console.WriteLine("You rubbish!");
            }
        }
    }
}
