using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{ //this kendini kasteder burada result classını kast eder 
    public class Result : IResult
    { 
        public Result(bool success, string message):this(success)
        {//SAADECE GET OLAN YANI READ ONLYLER CONSTRACTER DA SET EDİLEBİLİR PROGRAMCI KAFASINA GORE KODLAMSIN DİYE SET KOYMADIK VE PROGRAMCIYI KISITLAMIŞ OLDUK 
            Message = message;
        }

        public Result(bool success)//overlod (Aşırı yükleme)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
