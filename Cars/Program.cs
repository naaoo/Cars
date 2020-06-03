using Cars.controller;
using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            CarController carController = new CarController();
            string mode = "next";
            Console.WriteLine("Welcome to our Car-Generator!\n");
            while (mode.ToLower() == "next")
            {
                carController.gatherCarData();
                Console.WriteLine("Do you want to add another car or show all cars? (type in 'next' or 'show')");
                mode = Console.ReadLine();
                if (mode.ToLower().Equals("show"))
                {
                    view.View.showCars(carController.carList);
                    Console.WriteLine("\nAdd another car? (type in 'next' or 'quit')");
                    mode = Console.ReadLine();
                }
            }
        }
    }
}
