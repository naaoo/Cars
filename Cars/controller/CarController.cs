using Cars.model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cars.controller
{
    class CarController
    {
        public List<Car> carList = new List<Car>();
        public void gatherCarData()
        {
            Console.WriteLine("Please select your car-type:\n1: Casual\n2: Sports");
            int type = Int32.Parse(Console.ReadLine());
            CarType? carType = null;
            switch (type)
            {
                case 1:
                    carType = CarType.Casual; break;
                case 2:
                    carType = CarType.Sportscar; break;
            }
            Console.WriteLine("Please select a category:\n1: Sedan\n2: Coupe\n3: SUV\n4: Mini-Van");
            int category = Int32.Parse(Console.ReadLine());
            Category? carCategory = null;
            switch (category)
            {
                case 1:
                    carCategory = Category.Sedan; break;
                case 2:
                    carCategory = Category.Coupe; break;
                case 3:
                    carCategory = Category.SUV; break;
                case 4:
                    carCategory = Category.MiniVan; break;
            }
            Console.WriteLine("Brand:");
            string brand = Console.ReadLine();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Build year:");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Color:");
            string color = Console.ReadLine();
            switch ((CarType)carType)
            {
                case CarType.Casual:
                    carList.Add(new CasualCar((CarType)carType, (Category)carCategory, brand, name, year, color)); break;
                case CarType.Sportscar:
                    Console.WriteLine("test");
                    carList.Add(new SportsCar((CarType)carType, (Category)carCategory, brand, name, year, color)); break;
                    
            }
        }
    }
}
