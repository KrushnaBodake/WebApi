using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repository
{
    public class ProductRepository : IProductsRepository     // DAL
    {
        private readonly ApplicationDbContext db;

        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddProduct(Products prod)
        {
            int result = 0;
            db.Product.Add(prod);
            result= db.SaveChanges();
            return result;

        }

        public int DeleteProduct(int id)
        {

            int result = 0;
            var products = db.Product.Find(id);
            if (products != null)
            {
                db.Product.Remove(products);
                result = db.SaveChanges();
            }
            return result;

        }

        public IEnumerable<Products> GetAllProducts()
        {
            return db.Product.ToList();

        }

        public Products GetProductById(int id)
        {
            var product = db.Product.Find(id);
            return product;

        }

        public int UpdateProduct(Products prod)
        {
            int result = 0;
            var product = db.Product.Find(prod.Id);
            if (product != null)
            {
                product.Pname = prod.Pname;
                product.Price = prod.Price;
                product.Company = prod.Company;
                result = db.SaveChanges();
            }
            return result;

        }
    }
}
