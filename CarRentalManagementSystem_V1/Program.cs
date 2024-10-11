using System.Security.Cryptography.X509Certificates;

namespace CarRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var car1 = new Car("CAR_001", "TOYOTA", "prius", 10);
            //Console.WriteLine(car1);
            //Console.ReadLine();

            CarManager carManager = new CarManager();
            List<Car> car = new List<Car>();
            int option = 0;
            do
            {
                Console.WriteLine("Car Rental Management System: ");
                Console.WriteLine("1. Add a Car");
                Console.WriteLine("2. View ALl Cars");
                Console.WriteLine("3. Update a Car");
                Console.WriteLine("4. Delete a Car");
                Console.WriteLine("5. Exit");
                Console.Write("Choose and Option: ");
                option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        
                        Console.Clear();
                        Console.WriteLine("Enter Car Id");
                        var carId = Console.ReadLine();
                        Console.WriteLine("Enter Car Brand");
                        var brand = Console.ReadLine();
                        Console.WriteLine("Enter Car Model");
                        var model = Console.ReadLine();
                        Console.WriteLine("Enter Car Rental Price");
                        var rentalPrice = Convert.ToDecimal(Console.ReadLine());

                        
                        Console.WriteLine("Car added Successfully");

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("List Of Cars: ");
                        carManager.GetCars();
                        break;
                    case 3:
                        Console.Clear();

                        Console.WriteLine("Enter Car Id");
                        var carIdUpdate = Console.ReadLine();
                        Console.WriteLine("Enter New Car Brand");
                        var brandUpdate = Console.ReadLine();
                        Console.WriteLine("Enter New Car Model");
                        var modelUpdate = Console.ReadLine();
                        Console.WriteLine("Enter New Car Rental Price");
                        var rentalPriceUpdate = Convert.ToDecimal(Console.ReadLine());

                        carManager.UpdateCar(carIdUpdate, brandUpdate, modelUpdate, rentalPriceUpdate);
                        Console.WriteLine("Car Updated Successfully");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter Car Id");
                        var carIdDeleted = Console.ReadLine();
                        carManager.RemoveCar(carIdDeleted);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }
            }
            while (option != 5);


        }
    }
}
