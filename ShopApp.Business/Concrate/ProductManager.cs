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


        public bool Create(Product entity)
        {
            if(Validate(entity))
            {
                _productDal.Create(entity);
                return true;
            }
            return false;
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

        public Product GetByIdWithCategories(int id)
        {
            return _productDal.GetByIdWithCategories(id);
        }

        public int GetCountByCategory(string category)
        {
            return _productDal.GetCountByCategory(category);
        }

        public Product GetProductDetails(int id)
        {
            return _productDal.GetProductDetails(id);
        }

        public List<Product> GetProductsByCategory(string category,int page,int pageSize)
        {
            return _productDal.GetProductsByCategory(category, page, pageSize);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }

        public void Update(Product entity, int[] categoryIds)
        {
            _productDal.Update(entity, categoryIds);
        }

        public string ErrorMessage { get; set; }


        public bool Validate(Product entity)
        {
            var isValid = true;
            if(string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "ürün ismi girelisiniz";
                isValid = false;
            }
            return isValid;
        }
    }
}
