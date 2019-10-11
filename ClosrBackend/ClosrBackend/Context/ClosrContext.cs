using ClosrBackend.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosrBackend.Context
{
    public class ClosrContext: DbContext
    {

        public ClosrContext() { }
        public ClosrContext(DbContextOptions<ClosrContext> options) : base(options) { }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Merchant> Merchants { get; set; }

        
    }
}
