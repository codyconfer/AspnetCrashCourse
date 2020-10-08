using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Inventory;

namespace AspnetCrashCourse.Logic.Models.Inventory
{
    internal class Inventory : IInventory
    {
        public IEnumerable<IProduct> Stock { get; set; }
    }
}
