using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {   // data ve mesaj
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
                
        }
        //sadece data
        public SuccessDataResult(T data):base(data,true)
        {

        }
        // sadece mesaj çok fazla kullanımı yoktur
        public SuccessDataResult(string message):base(default,true,message)
        {
                
        }
        // boş çok fazla kulanımı yoktur 
        public SuccessDataResult():base(default,true)
        {
                
        }
    }
}
