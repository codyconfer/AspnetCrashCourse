using System;

namespace AspnetCrashCourse.Schema.Orders
{
    public interface ICardPayment : IPayment
    {
        string CardNumber { get; }
        int Ccv { get; }
        string Name { get; }
        DateTime ExpirationDate { get; }
    }
}
