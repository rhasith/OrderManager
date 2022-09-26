using System;
using System.Collections.Generic;

namespace OrderManager.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public int Status { get; set; }
    }
}
