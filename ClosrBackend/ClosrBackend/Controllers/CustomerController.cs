using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosrBackend.Context;
using ClosrBackend.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClosrBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ClosrContext _ctx { get; set; }

        public CustomerController(ClosrContext ctx)
        {
            _ctx = ctx;
        }

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {

            return _ctx.Customers.ToList();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Customer/5
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
