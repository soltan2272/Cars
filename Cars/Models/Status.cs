﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Status
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int StatusID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<OrderDetails> OrderDetails { get; set; }
        public virtual List<Quotation> Quotation { get; set; }
    }
}
