using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class Car
    {
         //name of the Car
        private string make; //Make of the car
        private string color;//color of car
        private double amount; //Amount of car
        private DateTime dt;//Date of purchase

       
        public void Start()
        {
            Console.WriteLine("Greetings from Car class!");
            DisplayCarInfo();
            ReadAndSaveCar();

        }
        private void DisplayCarInfo()
        {
            //Read a line of text
            Console.Write("What is the name of your Car? ");
            name = Console.ReadLine();

            //Read a line of text
            Console.Write("What is the make of your Car? ");
            make = Console.ReadLine();

            //Read a line of text
            Console.Write("What is the color of your Car? ");
            color = Console.ReadLine();

            //Read a line of text
            Console.Write("What is the price of your Car? ");
            amount = double.Parse(Console.ReadLine());

            Console.Write("When you had purchased your Car " + name + " of " + make + " ? (Enter valid date in format dd-mm-yyyy) ");
            dt = DateTime.Parse(Console.ReadLine());

        }



        private void ReadAndSaveCar()
        {
            Console.WriteLine("Your Have ");
            Console.WriteLine("Car " + name+ " " + make);
            Console.WriteLine("Color of your car is " + color + " and you purchased car at " +amount+ " SEK on " + dt);



        }
        private string name;
    }
}
