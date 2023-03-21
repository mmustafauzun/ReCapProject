using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using DataAccess.Abstract;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId+" "+car.CarDescription);
            }

            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine(car.CarId + " "+ car.CarModelYear+" "+car.CarDescription);
            }




        }
    }
}