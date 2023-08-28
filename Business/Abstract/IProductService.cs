using Entities.Concrete;
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
        List<Product> GetAll();
        public void Add(Product product);
       
    }
}
