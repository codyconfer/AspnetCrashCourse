namespace AspnetCrashCourse.Schema.Orders
{
    public interface IPayment
    {
        int Id { get; }
        Statuses.PaymentStatus PaymentStatus { get; }
        decimal Amount { get; }
        string Currency { get; }
        string CurrencySymbol { get; }
    }
}
