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
        public string GetAll()
        //public IEnumerable<Customer> Get()
        {

            return "df";
            //return _ctx.Customers.ToList();
        }

        // GET: api/Customer/5
        [HttpGet]
        [Route("{id}")]
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
        [HttpPut]
        [Route("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}
