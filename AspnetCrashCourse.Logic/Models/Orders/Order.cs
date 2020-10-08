using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Inventory;
using AspnetCrashCourse.Schema.Orders;
using AspnetCrashCourse.Schema.Promotions;
using static AspnetCrashCourse.Schema.Orders.Statuses;

namespace AspnetCrashCourse.Logic.Models.Orders
{
    public class Order : IOrder
    {
        public int Id { get; set; }
        public IEnumerable<IProduct> Cart { get; set; }
        public IEnumerable<IPromotion> Promotions { get; set; }
        public IEnumerable<IPayment> Payments { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
