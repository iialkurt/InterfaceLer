using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{

    //2. Olarak Product un işleneceği eylemler için soyut interface açıyoruz.
    // 3. Ekleme Kısmı DAL Daki Concrete içinde şu an memoryde çalıştığımız için
    // InMemory Klasöründe InMemoryProductDal sınıfını açıyoruz.
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDTO> GetProductDetails();
    }
}
// CODE REFACTORING