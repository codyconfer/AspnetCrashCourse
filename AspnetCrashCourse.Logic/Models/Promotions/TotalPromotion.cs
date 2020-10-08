using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Promotions;

namespace AspnetCrashCourse.Logic.Models.Promotions
{
    internal class TotalPromotion : Promotion, ITotalPromotion
    {
        public decimal MinTotal { get; set; }
    }
}
