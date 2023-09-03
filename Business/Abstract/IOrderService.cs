<<<<<<< HEAD
﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
=======
﻿using Entities.Concrete;
>>>>>>> 282ed2de6f011907e66542a4b154e39de9aece32
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {

<<<<<<< HEAD
        IDataResult<List<Order>> GetAll();
        //IDataResult<T> IDataResult interfacesinde  List<Order> GetaAll() şeklindeydi Idata
        //IdataResult ile bilgi döndüreceğiz.
               
        IResult Add(Order Order);


=======
      
      
>>>>>>> 282ed2de6f011907e66542a4b154e39de9aece32
    }
}
