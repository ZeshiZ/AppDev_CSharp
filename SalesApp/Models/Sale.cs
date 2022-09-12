﻿using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace SalesApp.Models
{
    class Sale : BaseModel
    {
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual SalesPerson Person { get; set; }

        [Required]
        public int PersonId { get; set; }

        public virtual SalesRegion Region { get; set; }

        [Required]
        public int RegionId { get; set; }
    }
}