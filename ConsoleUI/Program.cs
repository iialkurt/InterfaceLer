// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Business.Constans;
using DataAccess.Conctrete.EntityFramework;
using DataAccess.Conctrete.InMemory;
using Entities.Concrete;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {

        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        ProductManager productManager = new ProductManager(new EFProductDal());


       // ProductTest(productManager); // class metodtan dışarıda açılırsa bu şekilde
        OrderTest();                // class metodun içindeyse bu şekilde yazılır
      //  CategoryList(categoryManager);

       // Console.WriteLine("-----Kategori Numarasına Göre Listele");

      //  ProductManager pr = new ProductManager(new EFProductDal());

        //foreach (var pitem in pr.GetAll())
        //{
        //    Console.WriteLine(pitem.ProductName);
        //}



        //productManager.Add(new Product {ProductName = "Elma",CategoryId=1 });
        // productManager.Add(new Product { ProductId=7, ProductName = "Armut" });
        //productManager.Delete(new Product { ProductId = 1 });
        //productManager.Update(new Product { ProductId=6, ProductName="Elma ismi Karpuz oldu"});

    }

    private static void CategoryList(CategoryManager categoryManager)
    {
       
        Console.WriteLine("---------------------------------");
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }


    private static void ProductTest(ProductManager productManager)
    {

        var result = productManager.GetProductDetails();
        if (result.Success==true)
        {
            foreach (var product in result.Data)
            {

                Console.WriteLine("Product ID = " + product.ProductId.ToString() + " Product Name= " + product.ProductName
               + " - Category Name= " + product.CategoryName + " Unit Price= " + product.UnitPrice.ToString() + " Unit Stock= " + product.UnitsInStock.ToString());
                //categoryManager.GetAllByCategory(product.ProductId).ToString()


            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
        
       
    }



    private static void OrderTest()
    {
        OrderManager orderManager = new OrderManager(new EfOrderDal());

        var result = orderManager.GetAll();
      
       

        if (result.Success==true)
        {
            foreach (var orders in result.Data)
            {
                Console.WriteLine(orders.ShipCity);
            }
            
        }
        else
        {
            Console.WriteLine("Listelenemedi");
        }
       
    }


}