using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
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

        public IResult Add(Product product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),"ÜRün Listelendi");
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetMaxMinPrice(int min, int max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetMaxStockQuantity(int min, int max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductDetailDTO>> GetProductDetails()
        {
           return new SuccessDataResult<List<ProductDetailDTO>>(_productDal.GetProductDetails(),"Ürünler Listelendi");
        }
    }
}
