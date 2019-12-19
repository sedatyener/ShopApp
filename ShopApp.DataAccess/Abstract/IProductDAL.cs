using ShopApp.Entities;

namespace ShopApp.DataAccess.Abstract
{
    public interface IProductDAL:IRepository<Product>
    {
        Product GetProductDetails(int id);
    }
}
