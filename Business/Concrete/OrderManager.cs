using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Conctrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {

            _orderDal = orderDal;
        }


        public IResult Add(Order Order)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetAll()
        {
          //  return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "Ürünler Eklendi");
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(),"Ürünler Eklendi"); 
        }
    }
}
