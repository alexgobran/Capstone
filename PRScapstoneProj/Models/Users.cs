using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRScapstoneProj {
    public class Users {

        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Required]
       [StringLength(13)]
        public string Phone { get; set; }
        [Required]
        public string  Email { get; set; }
        [Required]
        public bool IsReviewer { get; set; } = false;
        [Required]
        public bool IsAdmin { get; set; } = false;

        public Users() { }
    }
}
