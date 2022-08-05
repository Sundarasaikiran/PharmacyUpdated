using System;
using System.Collections.Generic;

#nullable disable

namespace PharmacyUpdated.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public int? DrugId { get; set; }
        public int? Quantity { get; set; }
        public double? TotalAmount { get; set; }
        public string DrugName { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
