using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeExchange.Models
{
    public class Make
    {
        public int Id { get; set; }

        [Required]  // HH: Not Null
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
