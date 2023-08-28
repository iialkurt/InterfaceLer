using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    // Ekleme silme işlemlerin başarılı olup olmadığını API ye bildirmesi için yaptık.
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
