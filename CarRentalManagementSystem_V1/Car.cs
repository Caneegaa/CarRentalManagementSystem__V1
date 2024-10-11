using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    public class Car
    {

        private string CarId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal RentalPrice { get; set; }
        private int TotalCars { get; set; }

        public Car(string carId, string brand, string model, decimal rentalPrice)
        {
            CarId = carId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;

        }

        public override string ToString()
        {
            return $"ID: {CarId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice}";
        }

        public string getCarId()
        {
            return CarId ;
        }
        public string getBrand()
        {
            return Brand;
        }
        public string getModel()
        {
            return Model;
        }
        public decimal getRentalPrice()
        {
            return RentalPrice;
        }

        public virtual void DisplayCarInfo(string carId, string brand, string model, decimal rentalPrice)
        {
            Console.WriteLine($"{carId}, {brand}, {model}, {rentalPrice}");
        }


    }

    public class ElectricCar : Car
    {
        

        public decimal BatteryCapacity { get; set; }
        public int MotorPower { get; set; }
        public ElectricCar(string carId, string brand, string model, decimal rentalPrice) : base(carId, brand, model, rentalPrice)
        {
        }
        public override void DisplayCarInfo(string carId, string brand, string model, decimal rentalPrice)
        {
            Console.WriteLine($"{carId}, {brand}, {model}, {rentalPrice} ");
            
        }

    }

    public class PetrolCar : Car
    {
        public PetrolCar(string carId, string brand, string model, decimal rentalPrice) : base(carId, brand, model, rentalPrice)
        {
        }

        public decimal FuelTankCapacity { get; set; }
        public int EngineCapacity { get; set; }

        public override void DisplayCarInfo(string carId, string brand, string model, decimal rentalPrice)
        {
            Console.WriteLine($"{carId}, {brand}, {model}, {rentalPrice} ");

        }
    }
}
