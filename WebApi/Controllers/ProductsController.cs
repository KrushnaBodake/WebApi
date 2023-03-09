using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsServices service;
        public ProductsController(IProductsServices service)
        {
            this.service = service;
        }
        // api/Product/GetAllProducts--> url    attribute based routing
        [HttpGet]
        [Route("GetAllProducts")] // attribute based routing  - Route is class
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.GetAllProducts());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // api/Product/GetProductById/5
        [HttpGet]
        [Route("GetProductById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.GetProductsById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult Post([FromBody] Products prod)
        {
            try
            {
                int result = service.AddProduct(prod);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult Put([FromBody] Products prod)
        {
            try
            {
                int result = service.UpdateProduts(prod);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteProduct(id);
                if (result == 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

