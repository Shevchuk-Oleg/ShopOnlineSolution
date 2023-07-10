using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductMicroservices.Database;
using ProductMicroservices.Database.Entities;

namespace ProductMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        DatabaseContext db;
        public ProductController()
        {
            db = new DatabaseContext();
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return db.Products.ToList();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}", Name = "Get")]
        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public IActionResult Post([FromBody] Product model)
        {
            try
            {
                db.Products.Add(model);
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

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(Product ord)
        {
            db.Entry(ord).State = EntityState.Modified;
            Save();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var order = await db.Products.FindAsync(id);
            db.Products.Remove(order);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
