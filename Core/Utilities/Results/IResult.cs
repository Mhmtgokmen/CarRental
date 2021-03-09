using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{//voidler için temel başlangıç
    public interface IResult
    {
        bool Success { get; }// YAPMAYA CALIŞTIGIN İŞLEM BAŞARAILI MI BAŞARISIZ MI 

        string Message { get; }
    }
}
