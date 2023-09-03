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

        public IDataResult<List<Product>> GetAll()
        {
            //İş Kodları
            //Yetkisi Var mı?
        
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),"Ürünler Eklendi");
            
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2) 
            {
                return new ErrorResult(Messages.ProductNameInValid);

            }
            _productDal.Add(product);
            return new Result(true, Messages.ProductAdded);



        }

        public void Delete(Product product)
        {
          _productDal.Delete(product);  
        }
        public void Update(Product product)
        {
            _productDal.Update(product);    
        }

<<<<<<< HEAD
        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId==id),Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetMaxStockQuantity(int min, int max)
        {
            return  new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitsInStock >= min && p.UnitsInStock <= max),Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetMaxMinPrice(int min, int max)
        {
          return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.UnitPrice<=min && p.UnitPrice<=max),Messages.ProductListed);   
        }

        public IDataResult<List<ProductDetailDTO>> GetProductDetails()
        {
            return new SuccessDataResult <List<ProductDetailDTO>>(_productDal.GetProductDetails(),Messages.ProductListed);
            //throw new NotImplementedException();
        }

        public IDataResult<Product> ProductById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductId==productId));
        }

       
=======
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
>>>>>>> 282ed2de6f011907e66542a4b154e39de9aece32
    }
}
