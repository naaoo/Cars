using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.model
{
    class CasualCar : Car
    {
        public CasualCar(Type type, Category category, string brand, string name, int year, string color)
        {
            this.Type = type;
            this.Category = category;
            this.Brand = brand;
            this.Name = name;
            this.Year = year;
            this.Color = color;
        }
    }
}
