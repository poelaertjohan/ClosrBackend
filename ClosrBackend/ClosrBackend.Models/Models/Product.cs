using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClosrBackend.Models.Models
{
   public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string imgUrl { get; set; }
        public string Description { get; set; }
    }
}
