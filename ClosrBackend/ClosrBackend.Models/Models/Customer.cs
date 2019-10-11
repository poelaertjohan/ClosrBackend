using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClosrBackend.Models.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
    }
}
