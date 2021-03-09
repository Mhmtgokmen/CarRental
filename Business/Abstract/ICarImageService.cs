using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
       
        IDataResult<CarImage> Get(int id);

        IDataResult<List<CarImage>> GetAllByCarId(int id);

        IResult Add(CarImage carImage,string extension);

        IResult Update(CarImage carImage);

        IResult Delete(CarImage carImage);
    }
}
