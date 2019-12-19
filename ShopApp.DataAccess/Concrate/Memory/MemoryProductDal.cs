using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ShopApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDAL
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product{ Id=1,Name="Samsung S6",ImageUrl="1.jpg",Price=1000},
                new Product{ Id=1,Name="Samsung S7",ImageUrl="2.jpg",Price=2000},
                new Product{ Id=1,Name="Samsung S8",ImageUrl="3.jpg",Price=3000},
                new Product{ Id=1,Name="Samsung S9",ImageUrl="4.jpg",Price=4000}
            };
            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
