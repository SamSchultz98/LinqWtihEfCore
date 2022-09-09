using System;
using System.Collections.Generic;

namespace LinqWtihEfCore
{
    public partial class RequestLine
    {
        public int Id { get; set; }
        public int RequestsId { get; set; }
        public int ProductsId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Products { get; set; } = null!;
        public virtual Request Requests { get; set; } = null!;
    }
}
