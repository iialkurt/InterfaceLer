using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Conctrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    //5. Product Manager İŞ Katmanının Somut Sınıfı
    // Şimdi UI katmanındaki program cs den işlemlerimizi yapabiliriz.
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
        public void Update(Product product)
        {
            _productDal.Update(product);    
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetMaxStockQuantity(int min, int max)
        {
            return _productDal.GetAll(p => p.UnitsInStock >= min && p.UnitsInStock <= max);
        }

        public List<Product> GetMaxMinPrice(int min, int max)
        {
          return _productDal.GetAll(p=>p.UnitPrice<=min && p.UnitPrice<=max);   
        }

        public List<ProductDetailDTO> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
