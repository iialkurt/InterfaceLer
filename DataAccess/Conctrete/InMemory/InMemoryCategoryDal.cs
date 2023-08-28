using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conctrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
            public InMemoryCategoryDal()
        {
              _categories = new List<Category> {

                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Yedek Parça"}
            };
        }
        


List<Category> ICategoryDal.GetAll()
        {
          return _categories;
        }

        List<Category> ICategoryDal.GetAllByCategory(int categoryId)
        {
            return _categories;
        }
    }
}
