namespace AspnetCrashCourse.Schema.Inventory
{
    public interface IProduct<out TProductQuantity> where TProductQuantity : IProductQuantity
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        decimal UnitCost { get; }
        TProductQuantity Quantity { get; }
    }

    public interface IProduct : IProduct<IProductQuantity> { }
}
