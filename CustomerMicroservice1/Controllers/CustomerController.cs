using CustomerMicroservice1.Database;
using CustomerMicroservice1.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerMicroservice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        DatabaseContaxt db;
        public CustomerController() 
        {
            db = new DatabaseContaxt();
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return db.Customers.ToList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            return db.Customers.Find(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer model)
        {
            try
            {
                db.Customers.Add(model);
                db.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(Customer cust)
        {
            db.Entry(cust).State = EntityState.Modified;
            Save();
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            Save();
        }
    }
}
