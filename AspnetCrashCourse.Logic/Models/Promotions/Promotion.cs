using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Promotions;

namespace AspnetCrashCourse.Logic.Models.Promotions
{
    internal class Promotion : IPromotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public decimal DiscountPercentage { get; set; }
    }
}
