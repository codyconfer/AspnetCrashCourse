using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Inventory;

namespace AspnetCrashCourse.Logic.Models.Inventory
{
    internal class ProductQuantity : IProductQuantity
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
    }
}
