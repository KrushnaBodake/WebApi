using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Services
{
    public class ProductServices : IProductsServices
    {
        private readonly IProductsRepository repo;
        public ProductServices(IProductsRepository repo)
        {
            this.repo = repo;
        }

        public int AddProduct(Products prod)
        {
           return repo.AddProduct(prod);
        }

        public int DeleteProduct(int id)
        {
            return repo.DeleteProduct(id);
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return repo.GetAllProducts();
        }

        public Products GetProductsById(int id)
        {
            return repo.GetProductById(id);
        }

        public int UpdateProduts(Products prod)
        {
            return repo.UpdateProduct(prod);
        }
    }
}
