using Business.Abstract;
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
    public class OrderManager : IOrderDal
    {
        IOrderDal _orderdal;
        public OrderManager(IOrderDal orderdal)
        {

            _orderdal = orderdal;
        }

        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

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
        }
    }
}
