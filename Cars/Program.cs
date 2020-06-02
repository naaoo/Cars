using Cars.controller;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            CarController carController = new CarController();
            carController.gatherCarData();
        

        }

        
    }
}
