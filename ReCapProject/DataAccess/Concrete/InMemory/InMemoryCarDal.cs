using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,CarBrandId=1,CarColorId=1,CarDailyPrice=1200,CarModelYear=2023,CarDescription="Fiat Egea"},
                new Car {CarId=2,CarBrandId=2,CarColorId=2,CarDailyPrice=1300,CarModelYear=2023,CarDescription="Renault Clio"},
                new Car {CarId=3,CarBrandId=3,CarColorId=2,CarDailyPrice=1100,CarModelYear=2022,CarDescription="Citroen C Elysee"},
                new Car {CarId=4,CarBrandId=4,CarColorId=1,CarDailyPrice=712,CarModelYear=2023,CarDescription="Dacia Logan"},
                new Car {CarId=5,CarBrandId=5,CarColorId=1,CarDailyPrice=1280,CarModelYear=2022,CarDescription="Ford Tourneo Courier"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.CarDailyPrice = car.CarDailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
        }
    }
}
