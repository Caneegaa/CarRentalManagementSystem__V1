using System.Security.Cryptography.X509Certificates;

namespace CarRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("CAR_001", "TOYOTA", "prius", 10);
            Console.WriteLine(car1);
            Console.ReadLine();
        }
    }
}
