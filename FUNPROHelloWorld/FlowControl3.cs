using System;
using System.Collections.Generic;
using System.Text;

namespace FUNPROHelloWorld
{
    class FlowControl3
    {
        public FlowControl3()
        {
            List<string> data = new List<string>();
            data.Add("John");
            data.Add("Gabriel");
            data.Add("Luis");
            data.Add("Jose");
            data.Add("Jesus");
            data.Add("Carlos");
            data.Add("Jorge");
            data.Add("Marlon");
            foreach(string i in data) {
                Console.WriteLine($"{i}");
            }
        }
    }
}
