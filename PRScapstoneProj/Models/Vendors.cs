using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRScapstoneProj {
    public class Vendors {

        public int Id { get; set; }
        [Required]
        [StringLength(3)]
        
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        [StringLength(30)]
        public string City { get; set; }
        [Required]
        [StringLength(2)]
        public string State { get; set; }
        [Required]
        [StringLength(5)]
        public string Zip { get; set; }
        [Required]
        [StringLength(13)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

    }
}
