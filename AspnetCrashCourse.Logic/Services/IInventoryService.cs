using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Inventory;

namespace AspnetCrashCourse.Logic.Services
{
    public interface IInventoryService
    {
        IInventory GetInventory();
    }
}
