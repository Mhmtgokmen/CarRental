using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context=new CarContext())
            {
                var result = from c in context.Cars
                             join color in context.Colors
                             on c.ColorId equals color.ColorId
                             join r in context.Brands
                             on c.BrandId equals r.BrandId
                             select new CarDetailDto { Id = c.Id, ColorName=color.ColorName, BrandName = r.BrandName, DailyPrice = c.DailyPrice };
                return result.ToList();
                    
            }
        }
    }
}
