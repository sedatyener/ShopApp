using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System.Collections.Generic;
using System.Linq;


namespace ShopApp.Business.Concrate
{
    public class ProductManager : IProductService
    {
        //EfCoreProductDal _productDal = new EfCoreProductDal();

        //Dependency Injection
        private IProductDAL _productDal;
        public ProductManager(IProductDAL productDal)
        {
            _productDal = productDal;
        }


        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll().ToList();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
