using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRScapstoneProj {
    public class Vendors {

        public Vendors() { }


        public int Id { get; set; }
        [Required]
        [MaxLength(3), MinLength(3)]

        public string Code { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        [MaxLength(2), MinLength(2)]
        public string State { get; set; }
        [Required]
        [MaxLength(5), MinLength(5)]
        public string Zip { get; set; }
       
        [StringLength(12)]
        public string Phone { get; set; }
       
        [StringLength(255)]
        public string Email { get; set; }

    }
}
