﻿using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetProductDetails(int id);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(string category);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);


    }
}
