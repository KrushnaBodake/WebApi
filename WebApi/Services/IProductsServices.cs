using WebApi.Models;

namespace WebApi.Services
{
    public interface IProductsServices
    {
        IEnumerable<Products> GetAllProducts();
        Products GetProductsById(int id);
        int AddProduct(Products prod);
        int UpdateProduts(Products prod);
        int DeleteProduct(int id);
    }
}
