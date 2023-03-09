using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices services;
        public EmployeeController(IEmployeeServices services)
        {
            this.services = services;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        [Route("GetAllEmployees")]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(services.GetAllEmployees());

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // GET api/<EmployeeController>/5
        [HttpGet]
        [Route("GetEmployeeById{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(services.GetEmployeeById(id));
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent, ex.Message);
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Post([FromBody] Employee emp)
        {
            try
            {
                int result = services.AddEmployee(emp);
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
        [Route("UpdateEmployee")]
        public IActionResult Put([FromBody] Employee emp)
        {
            try
            {
                int result = services.UpdateEmployee(emp);
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

        // DELETE api/<EmployeeController>/5
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                int result = services.DeleteEmployee(id);
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
