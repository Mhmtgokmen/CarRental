using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{//Success ve message ı tekrar yazmaya gerek yok cünkü IResult da yazdık ve buraya implemente ettik 
   public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
