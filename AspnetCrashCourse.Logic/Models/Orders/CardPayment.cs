using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Orders;

namespace AspnetCrashCourse.Logic.Models.Orders
{
    internal class CardPayment : Payment, ICardPayment
    {
        public string CardNumber { get; set; }
        public int Ccv { get; set; }
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
