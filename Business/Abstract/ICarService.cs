using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<Car> GetCarsByBrandId(int id);

        IDataResult<Car> GetCarsByColorId(int id);

        IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max);

        IResult Add(Car car);

        IResult Update(Car car);

        IResult Delete(Car car);

        IDataResult<List<CarDetailDto>>  GetCarDetails();

        IResult AddTransactionalTest(Car car);//Transaction yönetimi, uygulamalarda tutarlılığı korumak için yaptığımız bir yöntem örneği hesabımda 100 lira var başka hesaba 10 lira göndericem, benim hesabın 10 lira azalması ve diğer hesabında 10 lira atrması seklinde update edilmesi gerek 
        // yani burada aynı süreçte iki veritabanı işlem var fakat benim hesabımdan para azaldı ama karşı tarafta para artmadı işlem hatalı oldu işlemi geri alması gerekir   

    }
}
