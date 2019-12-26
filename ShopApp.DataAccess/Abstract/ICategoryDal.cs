﻿using ShopApp.Entities;

namespace ShopApp.DataAccess.Abstract
{
    public interface ICategoryDAL:IRepository<Category>
    {
        Category GetByIdWithProducts(int id);
        void DeleteFromCategory(int categoryId, int productId);
    }
}
