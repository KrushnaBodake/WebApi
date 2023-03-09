using WebApi.Models;

namespace WebApi.Repository
{
    public interface IProductsRepository
    {
        IEnumerable<Products> GetAllProducts();
        Products GetProductById(int id);
        int AddProduct(Products prod);
        int UpdateProduct(Products prod);
        int DeleteProduct(int id);

    }
}
