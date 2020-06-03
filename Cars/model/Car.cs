using Cars.controller;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Cars.model
{
    class Car
    {
        public CarType CarType;
        public Category Category;
        public string Brand;
        public string Name;
        public int Year;
        public string Color;

        public Car(CarType type, Category category, string brand, string name, int year, string color)
        {
            this.CarType = type;
            this.Category = category;
            this.Brand = brand;
            this.Name = name;
            this.Year = year;
            this.Color = color;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}