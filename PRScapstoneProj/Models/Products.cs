using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PRScapstoneProj {
    public class Products {

        public int Id { get; set; }
        [Required]
        [StringLength(30)]

        public string PartNbr { get; set; }
        [Required]
        [StringLength(30)]

        public string Name { get; set; }
        [Required]
       
        public decimal Price { get; set; }
        [Required]

        public string Unit { get; set; }
        [StringLength(255)]

        public string PhotoPath { get; set; }

        [Required]
        public int VendorId { get; set; }
    }


}
