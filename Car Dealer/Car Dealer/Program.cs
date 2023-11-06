using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carlists dealership = new Carlists();

            // Add car1 using Tuple
            var car1 = new Tuple<string, string, int>("Ford", "abc-123", 125987);
            dealership.AddCar(car1.Item1, car1.Item2, car1.Item1, car1.Item3);

            dealership.AddCar("Toyota", "Camry", "ABC123", 50000);
            dealership.AddCar("Honda", "Civic", "XYZ456", 60000);
            dealership.AddCar("Ford", "Focus", "DEF789", 45000);
            dealership.AddCar("Toyota", "Corolla", "GHI012", 55000);

            Console.WriteLine("Search by brand: ");
            string input = Console.ReadLine();
            List<Car> toyotaCars = dealership.CarByBrand(input);
            foreach (Car car in toyotaCars)
            {
                Console.WriteLine($"{car.Brand} {car.Model}, Mileage: {car.Mileage}");
            }

            Console.WriteLine("\nLeast driven cars:");
            List<Car> leastDriven = dealership.LeastDrivenCars(2);
            foreach (Car car in leastDriven)
            {
                Console.WriteLine($"{car.Brand} {car.Model}, Mileage: {car.Mileage}");
            }

            Console.ReadLine();
        }
    }
}
