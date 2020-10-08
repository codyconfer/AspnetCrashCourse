using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AspnetCrashCourse.Logic.Models.Inventory;
using AspnetCrashCourse.Schema.Inventory;

namespace AspnetCrashCourse.Logic.Services
{
    public class MockInventoryService : IInventoryService
    {
        public IInventory GetInventory() =>
            CreateMockInventory();

        public static IInventory CreateMockInventory() =>
            new Inventory
            {
                Stock = CreateMockProductList().ToArray()
            };

        public static IEnumerable<IProduct> CreateMockProductList() =>
            new List<IProduct>
            {
                new Product
                {
                    Id = 0,
                    Name = "Sugar",
                    Description = "Sugar",
                    UnitCost = 1.99m,
                    Quantity = CreateMockProductQuantity(0)
                },
                new Product
                {
                    Id = 1,
                    Name = "Salt",
                    Description = "Salt",
                    UnitCost = 2.99m,
                    Quantity = CreateMockProductQuantity(1)
                },
                new Product
                {
                    Id = 2,
                    Name = "Flour",
                    Description = "Flour",
                    UnitCost = 0.99m,
                    Quantity = CreateMockProductQuantity(2)
                },
                new Product
                {
                    Id = 3,
                    Name = "Pepper",
                    Description = "Pepper",
                    UnitCost = 4.99m,
                    Quantity = CreateMockProductQuantity(3)
                },
                new Product
                {
                    Id = 4,
                    Name = "Paprika",
                    Description = "Paprika",
                    UnitCost = 6.99m,
                    Quantity = CreateMockProductQuantity(4)
                },
            };

        public static IProductQuantity CreateMockProductQuantity(int productId) =>
            new ProductQuantity
            {
                Id = productId,
                Quantity = 100m,
                Unit = "lb"
            };
    }
}
