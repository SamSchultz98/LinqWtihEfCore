using System;
using System.Collections.Generic;

namespace LinqWtihEfCore
{
    public partial class Product
    {
        public Product()
        {
            RequestLines = new HashSet<RequestLine>();
        }

        public int Id { get; set; }
        public string PartNbr { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Unit { get; set; } = null!;
        public string? Photopath { get; set; }
        public int VendorsId { get; set; }

        public virtual Vendor Vendors { get; set; } = null!;
        public virtual ICollection<RequestLine> RequestLines { get; set; }
    }
}
