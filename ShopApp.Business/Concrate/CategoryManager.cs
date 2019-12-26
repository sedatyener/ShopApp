using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Concrate
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }
        public void Create(Category entity)
        {
            _categoryDAL.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public void Update(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}
