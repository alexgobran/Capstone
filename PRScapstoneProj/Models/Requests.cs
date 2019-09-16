using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PRScapstoneProj {
    public class Requests {
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
        public double Total { get; set; } = 0;
        [Required]
        public int UserId { get; set; }

    }
}
