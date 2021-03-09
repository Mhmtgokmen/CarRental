using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        // interface meteotları default publictir interface classı degil.
        List<CarDetailDto> GetCarDetails();
    }
}
