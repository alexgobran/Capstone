using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRScapstoneProj {

   
    public class RequestLines {

        public virtual Products Product { get; set; }

        public RequestLines() { }

        public int Id { get; set; } = 0;
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 1;


        
      

    }
}
