using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car()
            {
                Color = "Black",
                BodyType = "Sedan",
                Brand = "BMW",
                Model = "M5"
            };
            Console.WriteLine($"Color: {Car1.Color}\nBodyType: {Car1.BodyType}\nBrand: {Car1.Brand}\nModel: {Car1.Model}");
            Console.WriteLine("===================\n\n");
            Car Car2 = new Car()
            {
                Color = "White",
                BodyType = "Coupe",
                Brand = "Toyota",
                Model = "Supra"
            };
            Car Car3 = new Car()
            {
                Color = "Blue",
                BodyType = "Coupe",
                Brand = "Bugatti",
                Model = "Chiron"
            };
            Car Car4 = new Car()
            {
                Color = "Grey",
                BodyType = "Suv",
                Brand = "Audi",
                Model = "Q7"
            };
            Car Car5 = new Car()
            {
                Color = "White",
                BodyType = "Pickup",
                Brand = "Nissan",
                Model = "Navara"
            };
            Car Car6 = new Car()
            {
                Color = "Black",
                BodyType = "Touring",
                Brand = "Jeep",
                Model = "Wrangler"
            };
            Car[] Cars = {Car1,Car2,Car3,Car4,Car5,Car6};
            foreach (var vehicle in Cars)
            {
                Console.WriteLine($"Color: {vehicle.Color}\nBodyType: {vehicle.BodyType}\nBrand: {vehicle.Brand}\nModel: {vehicle.Model}");
                Console.WriteLine("===================");
            }
        }
    }
}
