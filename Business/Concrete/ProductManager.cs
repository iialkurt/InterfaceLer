using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Conctrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    //5. Product Manager İŞ Katmanının Somut Sınıfı
    //
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş Kodları
            //Yetkisi Var mı?
        
            return _productDal.GetAll();
            
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
          
        }

        public void Delete(Product product)
        {
          _productDal.Delete(product);  
        }
    }
}
