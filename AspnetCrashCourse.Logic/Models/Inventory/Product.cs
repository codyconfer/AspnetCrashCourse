using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Inventory;

namespace AspnetCrashCourse.Logic.Models.Inventory
{
    internal class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitCost { get; set; }
        public IProductQuantity Quantity { get; set; }
    }
}
