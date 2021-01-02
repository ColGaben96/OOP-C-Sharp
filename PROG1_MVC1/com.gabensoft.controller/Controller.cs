using System;
using PROG1_MVC1.com.gabensoft.model;

namespace PROG1_MVC1.com.gabensoft.controller
{
    class Controller
    {
        private Mundo modelo = new Mundo();
        public void consoleExample()
        {
            Console.WriteLine("Number 2 Text by Gabensoft");
            Console.Write("\nEnter a number:");
            int nums = int.Parse(Console.ReadLine());
            Console.WriteLine(modelo.GetNumber2Text().num2text(nums));
        }
    }

    class Launcher
    {
        static void Main()
        {
            Controller c = new Controller();
            c.consoleExample();
        }
    }
}
