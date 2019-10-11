using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClosrBackend.Models.Models
{
    public class Merchant
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public List<Product> Products { get; set; }
    }
}
