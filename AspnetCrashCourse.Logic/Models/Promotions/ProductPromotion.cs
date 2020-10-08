using System;
using System.Collections.Generic;
using System.Text;
using AspnetCrashCourse.Schema.Promotions;

namespace AspnetCrashCourse.Logic.Models.Promotions
{
    internal class ProductPromotion : Promotion, IProductPromotion
    {
        public int ProductId { get; set; }
    }
}
