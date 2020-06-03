using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.model
{
    class SportsCar : Car
    {
        public SportsCar(CarType type, Category category, string brand, string name, int year, string color)
            : base(type, category, brand, name, year, color)
        {
        }
    }
}
