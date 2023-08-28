using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conctrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        //List<Category> _categories;
        //    public InMemoryCategoryDal()
        //{
        //      _categories = new List<Category> {

        //        new Category{CategoryId=1,CategoryName="Bilgisayar"},
        //        new Category{CategoryId=2,CategoryName="Yedek Parça"}
        //    };
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }



    
    }

