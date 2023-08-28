// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Conctrete.InMemory;
using Entities.Concrete;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new InMemoryProductDal());
        CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());



        

        productManager.Add(new Product { ProductName = "Elma" });
        productManager.Add(new Product { ProductName = "Armut" });
      // productManager.Delete(new Product { ProductId = 1 });


        foreach (var product in productManager.GetAll())
        {

            Console.WriteLine("Product ID = "+product.ProductId.ToString()+" Product Name= "+product.ProductName + " " + product.CategoryId.ToString() + " " + product.UnitPrice.ToString() + " " + product.UnitsInStock.ToString() + categoryManager.GetAllByCategory(product.CategoryId).ToString());
            foreach (var categories in categoryManager.GetAllByCategory(product.ProductId)) ;
            {
                //Console.WriteLine(categories.CategoryName);
            }

        }

    }
}