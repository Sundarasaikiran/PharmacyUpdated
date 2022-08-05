using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyUpdated.Models
{
    public partial class Drug
    {
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? SupplierId { get; set; }
    }
}
