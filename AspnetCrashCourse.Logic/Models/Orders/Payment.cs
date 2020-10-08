using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Orders;
using static AspnetCrashCourse.Schema.Orders.Statuses;

namespace AspnetCrashCourse.Logic.Models.Orders
{
    internal class Payment : IPayment
    {
        public int Id { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string CurrencySymbol { get; set; }
    }
}
