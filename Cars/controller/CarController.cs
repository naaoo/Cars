using Cars.model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cars.controller
{
    class CarController
    {
        List<Car> carList = new List<Car>();
        public void gatherCarData()
        {
            Console.WriteLine("Welcome to our Car-Generator!\nPlease select your car-type:\n1: Casual\n2: Sports");
            int carType = Int32.Parse(Console.ReadLine());
            model.Type? type = null;
            switch (carType)
            {
                case 1:
                    type = model.Type.Casual; break;
                case 2:
                    type = model.Type.Sportscar; break;
            }
            Console.WriteLine("Please select a category:\n1: Sedan\n2: Coupe\n3: SUV\n4: Mini-Van");
            int carCategory = Int32.Parse(Console.ReadLine());
            Category? category = null;
            switch (carCategory)
            {
                case 1:
                    category = Category.Sedan; break;
                case 2:
                    category = Category.Coupe; break;
                case 3:
                    category = Category.SUV; break;
                case 4:
                    category = Category.MiniVan; break;
            }
            Console.WriteLine("Brand:");
            string brand = Console.ReadLine();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Build year:");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Color:");
            string color = Console.ReadLine();
            carList.Add(new Car((model.Type)type, (Category)category, brand, name, year, color));
        }
    }
}
