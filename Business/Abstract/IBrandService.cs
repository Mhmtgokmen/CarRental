﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();

        IDataResult<Brand> GetByBrandId(int id);

        IResult Add(Brand brand);

        IResult Updata(Brand brand);

        IResult Delete(Brand brand);
            
    }
}
