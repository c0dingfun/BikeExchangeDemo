using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BikeExchange.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }
        [Required]  // HH: Not Null in SQL 
        [MaxLength(255)]
        [DisplayName("Model")]
        public string Name { get; set; }

        public Make Make { get; set; }
        [ForeignKey("Make")]
        public int MakeFK { get; set; }
    }
}
