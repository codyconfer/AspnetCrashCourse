using System.Collections.Generic;

namespace AspnetCrashCourse.Schema.Inventory
{
    public interface IInventory
    {
        IEnumerable<IProduct> Stock { get; }
    }
}
