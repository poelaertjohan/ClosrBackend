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
    public class CustomerController : Controller
    {
        private ClosrContext _ctx { get; set; }

        public CustomerController(ClosrContext ctx)
        {
            _ctx = ctx;
        }

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            return _ctx.Customers.ToList();
        }

        // GET: api/Customer/5
        [HttpGet]
        [Route("{id}")]
        public Customer Get(int id)
        {
            return _ctx.Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _ctx.Add(value);
        }

        // PUT: api/Customer/5
        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("{id}")]
        public void Delete(Customer c)
        {
            _ctx.Remove(c);
        }
    }
}
