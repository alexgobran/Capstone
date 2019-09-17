using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRScapstoneProj {
    public class Products {

        public Products() { }

        public virtual Vendors Vendor { get; set; }

        public int Id { get; set; }
        [Required]
        [StringLength(30)]

        public string PartNbr { get; set; }
        [Required]
        [StringLength(30)]

        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Price { get; set; }
        [Required]

        public string Unit { get; set; }
        [StringLength(255)]

        public string PhotoPath { get; set; }
        [ForeignKey("Vendor")]
        [Required]
        public int VendorId { get; set; }
    }


}
