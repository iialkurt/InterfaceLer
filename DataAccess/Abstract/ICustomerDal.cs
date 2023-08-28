using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;


namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
