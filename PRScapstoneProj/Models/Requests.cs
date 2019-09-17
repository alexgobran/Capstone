using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRScapstoneProj {

    

    public class Requests {
    

        public virtual RequestLines Request { get; set; }

        public virtual Users User { get; set; }
        public Requests() { }

        [Required]
        public int Id { get; set; }
        [StringLength(80)]
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(80)]
        public string Justification { get; set; }
        [StringLength(80)]
        public string RejectionReason { get; set; }
        [Required]
        [StringLength(20)]
        public string DeliveryMode { get; set; } = "Pickup";
        [StringLength(10)]
        [Required]
        public string Status { get; set; } = "NEW";
        [Required]
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Total { get; set; } = 0;
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

   
            
    
    }
}
