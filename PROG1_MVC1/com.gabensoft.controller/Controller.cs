using System;
using PROG1_MVC1.com.gabensoft.model;
using PROG1_MVC1.com.gabensoft.view;

namespace PROG1_MVC1.com.gabensoft.controller
{
    class Controller
    {
        private Mundo modelo = new Mundo();
        private MainForm vista = new MainForm();
        public void consoleExample()
        {
            Console.WriteLine("Number 2 Text by Gabensoft");
            Console.Write("\nEnter a number:");
            int nums = int.Parse(Console.ReadLine());
            Console.WriteLine(modelo.GetNumber2Text().num2text(nums));
        }

        public string getTextConversion(int numbers)
        {
            return modelo.GetNumber2Text().num2text(numbers);
        }

        [STAThread]
        public void startGUI()
        {
            vista.start(this);
        }
    }

    class Launcher
    {
        static void Main()
        {
            Controller c = new Controller();
            c.startGUI();
        }
    }
}
