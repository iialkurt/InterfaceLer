using Business.Abstract;
<<<<<<< HEAD
using Business.Constans;
using Core.Utilities.Results;
=======
>>>>>>> 282ed2de6f011907e66542a4b154e39de9aece32
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
<<<<<<< HEAD
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {

            _orderDal = orderDal;
        }


        public IResult Add(Order Order)
=======
    public class OrderManager : IOrderDal
    {
        IOrderDal _orderdal;
        public OrderManager(IOrderDal orderdal)
        {

            _orderdal = orderdal;
        }

        public void Add(Order entity)
>>>>>>> 282ed2de6f011907e66542a4b154e39de9aece32
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public IDataResult<List<Order>> GetAll()
        {
          //  return new SuccessDataResult<List<Product>>(_productDal.GetAll(), "Ürünler Eklendi");
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(),"Ürünler Eklendi"); 
=======
        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            return _orderdal.GetAll();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
>>>>>>> 282ed2de6f011907e66542a4b154e39de9aece32
        }
    }
}
