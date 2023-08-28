using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conctrete.InMemory
{/// <summary>
/// 3. Olarak Veritabanında yapılacak işlemleri somut  şekilde yapılan yerdir.
/// Entitiy framework olabilir. ADO.NET olabilir. DApper vss. olabilir.
/// 4. Ekleme Kısmı Business iş katmanında Abstrack klasöründe soyut olarak IProductService interfacesini açıyoruz.
/// </summary>
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
       

        public InMemoryProductDal()
        {
            //Oracle,Sql Server, Postgres, MangoDb

           
                
            _products = new List<Product>
           
            {
                new Product{ProductId=1, ProductName="Bardak",CategoryId=1,UnitPrice=15,UnitsInStock=15 },
                new Product{ProductId=2, ProductName="Kamera",CategoryId=1,UnitPrice=500,UnitsInStock=3 },
                new Product{ProductId=3, ProductName="Telefon",CategoryId=2,UnitPrice=1500,UnitsInStock=45 },
                new Product{ProductId=4, ProductName="Klavye",CategoryId=2,UnitPrice=150,UnitsInStock=55 },
                new Product{ProductId=5, ProductName="Mouse",CategoryId=2,UnitPrice=85,UnitsInStock=65 }


            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product? productToDelete = null;
             productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
             _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
           throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>>? filter = null)
        {
            return _products;
        }

        public List<ProductDetailDTO> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product? productToUpdate = null;
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}



//public void Add(Product product)
//{
//    _products.Add(product);
//}

//public void Delete(Product product)
//{
//    Product? productToDelete = null;
//    productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
//    _products.Remove(productToDelete);
//}

//public List<Product> GetAll()
//{
//    return _products;
//}

//public List<Product> GetAllByCategory(int categoryId)
//{
//    return _products.Where(p => p.CategoryId == categoryId).ToList();
//}





//public void Update(Product product)
//{
//    Product? productToUpdate = null;
//    productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
//    productToUpdate.ProductName = product.ProductName;
//    productToUpdate.CategoryId = product.CategoryId;
//    productToUpdate.UnitPrice = product.UnitPrice;
 //   productToUpdate.UnitsInStock = product.UnitsInStock;
//}