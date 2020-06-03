using Cars.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.view
{
    class View
    {
        public static void showCars(List<Car> carList)
        {
            Console.WriteLine("\nYour cars:");
            foreach (Car car in carList)
            {
                Console.WriteLine(car.CarType + ", " + car.Category + ", " + car.Brand + ", "
                    + car.Name + ", " + car.Year + ", " + car.Color);
            }
        }
    }
}
