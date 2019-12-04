using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP2084_a1_shoestore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COMP2084_a1_shoestore.API
{
    [Route("api/shoes")]
    [ApiController]
    public class V1Controller : Controller
    {
        private readonly ShoeStoreContext _context;

        public V1Controller(ShoeStoreContext context)
        {
            _context = context;
        }

        // GET: api/V1
        [HttpGet]
        public IActionResult Get()
        {
            var theSongs = _context.Shoe.ToList();
            return Json(theShoes);
        }

        // GET: api/V1/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var theSong = _context.Shoe.Where(s => s.ShoeId == id).SingleOrDefault();
            return Json(theSong);
        }

        // POST: api/V1
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/V1/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
