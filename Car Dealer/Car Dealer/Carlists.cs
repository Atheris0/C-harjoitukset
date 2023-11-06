using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealer
{
    internal class Carlists
    {
        private List<Car> carList = new List<Car>();

        public void AddCar(string brand, string model, string licensePlate, int mileage)
        {
            Car car = new Car
            {
                Brand = brand,
                Model = model,
                LicensePlate = licensePlate,
                Mileage = mileage
            };

            carList.Add(car);
        }

        public List<Car> CarByBrand(string brand)
        {
            List<Car> carsByBrand = carList.FindAll(car => car.Brand == brand);
            return carsByBrand;
        }

        public List<Car> LeastDrivenCars(int count)
        {
            List<Car> leastDrivenCars = carList.OrderBy(car => car.Mileage).Take(count).ToList();
            return leastDrivenCars;
        }


    }
}
