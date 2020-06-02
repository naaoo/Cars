using Cars.controller;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Cars.model
{
    class Car
    {
        public Type Type;
        public Category Category;
        public string Brand;
        public string Name;
        public int Year;
        public string Color;

        public Car(Type type, Category category, string brand, string name, int year, string color)
        {
            switch (type)
            {
                case Type.Casual:
                    new CasualCar(type, category, brand, name, year, color); break;
                case Type.Sportscar:
                    new SportsCar(type, category, brand, name, year, color); break;
            }
            
        }
    }
}

    



