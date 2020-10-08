namespace AspnetCrashCourse.Schema.Inventory
{
    public interface IProductQuantity
    {
        int Id { get; }
        decimal Quantity { get; }
        string Unit { get; }
    }
}
