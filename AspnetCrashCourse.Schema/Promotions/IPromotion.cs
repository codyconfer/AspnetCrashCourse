using System;

namespace AspnetCrashCourse.Schema.Promotions
{
    public interface IPromotion
    {
        int Id { get; }
        string Name { get; }
        DateTimeOffset StartDate { get; }
        DateTimeOffset EndDate { get; }
        decimal DiscountPercentage { get; }
    }
}
