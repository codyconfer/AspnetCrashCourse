using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Promotions;

namespace AspnetCrashCourse.Logic.Models.Promotions
{
    internal class PromoCode : Promotion, IPromoCode
    {
        public string Code { get; set; }
    }
}
