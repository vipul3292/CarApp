// Program.cs  (Start Class)
// Created By: Aishwarya Joshi


using System; // compiler is looking in the System namespace for the class, Console
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CarApp
{
    public class Program
    {
        static void Main()
        {
            Program p1 = new Program();
            p1.EndlessOrNot();
            double number1 = 0.0;
            double number2 = 6.0;

            if ((number2 != 0.0) && (number1 > 0.0))
                number1 = number2 / 2;
            number2 = number1;
            double intValue = (int)3.6;

            Console.WriteLine(intValue);
            Console.ReadLine();

            PrepareConsoleLook();
            //Create Car Object
            Car carObj = new Car();
            //Call a method of Object to run
            carObj.Start();

            Console.WriteLine("Thanks. Press enter to exit the program!");
            Console.ReadLine();  // read something
                    }
        public void EndlessOrNot()
        {
            int number = 0;
            string strNumber;
            int count = 0;

            while (true)
            {

                strNumber = Console.ReadLine();
                number = int.Parse(strNumber);

                if (number > 10)

                    break;
            }
        }



        static void PrepareConsoleLook()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Car";
        }
    }
}