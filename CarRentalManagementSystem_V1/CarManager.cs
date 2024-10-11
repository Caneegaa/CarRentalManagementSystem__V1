using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class CarManager
    {
        public List<Car> Cars = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
            Console.WriteLine("Car Added Successfully");
        }

        public List<Car> GetCars()
        {
            return Cars;
        }

        public void UpdateCar(string carId, string brand, string model, decimal rentalPrice)
        {
             
            var tobeUpdated = Cars.SingleOrDefault(c => c.getCarId() == carId);

            
            var Brand = tobeUpdated.getBrand();
            var Model = tobeUpdated.getModel();
            var RentalPrice = tobeUpdated.getRentalPrice();

            
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;
            

            Console.WriteLine("Car Updated Successfully");
        }
        public void RemoveCar(string carId)
        {
            var tobedeleted = Cars.SingleOrDefault(c => c.getCarId() == carId);
            Cars.Remove(tobedeleted);
            Console.WriteLine("Car Deleted Successfully");
        }
    }
}
