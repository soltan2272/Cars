﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class DraftOrderDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long DraftOrderDetailsId { get; set; }      
        public string Items { get; set; }
        public int? Quantity { get; set; }
        public long DraftOrderID { get; set; }
        [ForeignKey("DraftOrderID")]
        public DraftOrder DraftOrder { get; set; }

        public int? OrderDetailsTypeID { get; set; }
        [ForeignKey("OrderDetailsTypeID")]
        public OrderDetailsType OrderDetailsType { get; set; }

        [Required]
        public string SystemUserCreate { get; set; }
        public DateTime DTsCreate { get; set; }

        public string SystemUserUpdate { get; set; }
        public DateTime? DTsUpdate { get; set; }
    }
}
