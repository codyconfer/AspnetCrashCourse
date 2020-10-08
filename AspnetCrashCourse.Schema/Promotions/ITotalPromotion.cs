namespace AspnetCrashCourse.Schema.Promotions
{
    public interface ITotalPromotion : IPromotion
    {
        decimal MinTotal { get; }
    }
}
