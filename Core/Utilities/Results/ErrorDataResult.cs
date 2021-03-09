using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{ 
        public class ErrorDataResult<T> : DataResult<T>
        {   // data ve mesaj
            public ErrorDataResult(T data, string message) : base(data, false, message)
            {

            }
            //sadece data
            public ErrorDataResult(T data) : base(data, false)
            {

            }
            // sadece mesaj çok fazla kullanımı yoktur
            public ErrorDataResult(string message) : base(default, false, message)
            {

            }
            // boş çok fazla kulanımı yoktur 
            public ErrorDataResult() : base(default, false)
            {

            }
        }
    
}
