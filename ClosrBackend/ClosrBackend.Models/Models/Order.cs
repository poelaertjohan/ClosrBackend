using System;
using System.Collections.Generic;
using System.Text;

namespace ClosrBackend.Models.Models
{
public  class Order
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
