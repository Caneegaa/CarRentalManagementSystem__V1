using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    internal class Car
    {
        private string CarId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal RentalPrice { get; set; }

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

        

    }
}
