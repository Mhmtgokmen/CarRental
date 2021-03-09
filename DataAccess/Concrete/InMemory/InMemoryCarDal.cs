﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,BrandName="VOLVO", ColorId=2,ModelYear=2019,DailyPrice=200,Description="Manuel Vites,Benzinli" },
                new Car{Id=2,BrandId=4,BrandName="AUDİ",ColorId=3,ModelYear=2018,DailyPrice=250,Description="Otomatik Vites,Dizel" },
                new Car{Id=3,BrandId=2,BrandName="TOYOTA",ColorId=3,ModelYear=2017,DailyPrice=225,Description="Otomatik Vites,Dizel" },
                new Car{Id=4,BrandId=3,BrandName="BMW",ColorId=2,ModelYear=2020,DailyPrice=300,Description="Otomatik Vites,Dizel" },
                new Car{Id=5,BrandId=1,BrandName="Citroen", ColorId=2,ModelYear=2019,DailyPrice=200,Description="Manuel Vites,Benzinli" },
                new Car{Id=6,BrandId=4,BrandName="FORD",ColorId=3,ModelYear=2018,DailyPrice=250,Description="Otomatik Vites,Dizel" },
                new Car{Id=7,BrandId=2,BrandName="Hyundai",ColorId=3,ModelYear=2017,DailyPrice=225,Description="Otomatik Vites,Dizel" },
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();//ekleme yaparak istediğimiz gibi listeleme yapabiliriz.
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate= _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
