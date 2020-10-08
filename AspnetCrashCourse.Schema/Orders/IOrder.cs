using System.Collections.Generic;
using AspnetCrashCourse.Schema.Inventory;
using AspnetCrashCourse.Schema.Promotions;

namespace AspnetCrashCourse.Schema.Orders
{
    public interface IOrder<out TProduct, out TPromotion, out TPayment>
        where TProduct : IProduct<IProductQuantity>
        where TPromotion : IPromotion
        where TPayment : IPayment
    {
        int Id { get; }
        IEnumerable<TProduct> Cart { get; }
        IEnumerable<TPromotion> Promotions { get; }
        IEnumerable<TPayment> Payments { get; }
        Statuses.OrderStatus OrderStatus { get; }
    }

    public interface IOrder : IOrder<IProduct, IPromotion, IPayment> { }
}
