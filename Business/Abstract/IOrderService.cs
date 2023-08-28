using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {

        IDataResult<List<Order>> GetAll();
        //IDataResult<T> IDataResult interfacesinde  List<Order> GetaAll() şeklindeydi Idata
        //IdataResult ile bilgi döndüreceğiz.
               
        IResult Add(Order Order);


    }
}
