//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using ShopOnline.Api.Entities;
//using ShopOnline.Api.Data;

//namespace ShopOnline.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class Controller : ControllerBase
//    {
//        DatabaseContext db;
//        public Controller()
//        {
//            db = new DatabaseContext();
//        }
//        // GET: api/<ProductController>
//        [HttpGet]
//        public IEnumerable<Product> Get()
//        {
//            return db.Products.ToList();
//        }

//        // GET api/<ProductController>/5
//        [HttpGet("{id}", Name = "Get")]
//        public Product Get(int id)
//        {
//            return db.Products.Find(id);
//        }

//        // POST api/<ProductController>
//        [HttpPost]
//        public IActionResult Post([FromBody] Product model)
//        {
//            try
//            {
//                db.Products.Add(model);
//                db.SaveChanges();

//                return StatusCode(StatusCodes.Status201Created, model);
//            }
//            catch (Exception ex)
//            {

//                return StatusCode(StatusCodes.Status500InternalServerError, ex);
//            }
//        }
//        public void Save()
//        {
//            db.SaveChanges();
//        }
//        // PUT api/<ProductController>/5
//        [HttpPut("{id}")]
//        public void Put(Product Produc)
//        {
//            db.Entry(Produc).State = EntityState.Modified;
//            Save();
//        }

//        // DELETE api/<ProductController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//            var product = db.Products.Find(id);
//            db.Products.Remove(product);
//            Save();
//        }
//    }
//}
