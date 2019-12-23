using ShopApp.Entities;
using System.Collections.Generic;

namespace ShopApp.DataAccess.Abstract
{
    public interface IProductDAL:IRepository<Product>
    {
        Product GetProductDetails(int id);
        List<Product> GetProductsByCategory(string category,int page,int pageSize);
        int GetCountByCategory(string category);
    }
}
