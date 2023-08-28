using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{

    // 4. İş Katmanında ürün servisi açıyoruz Soyut
    // iş katmanında kullanacağımız servis operasyonları
    //5. ProductManager somut iş koduna geçelim.
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        //IDataResult<T> IDataResult interfacesinde  List<Product> GetaAll() şeklindeydi Idata
        //IdataResult ile bilgi döndüreceğiz.
        IDataResult<List<Product>> GetAllByCategoryId(int id);  
        IDataResult<List<Product>> GetMaxStockQuantity(int min, int max);
        IDataResult<List<Product>> GetMaxMinPrice(int min, int max);
        IDataResult<List<ProductDetailDTO>> GetProductDetails();
        
        
        IResult Add(Product product);
    



    }
}
