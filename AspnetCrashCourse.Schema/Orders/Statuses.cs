namespace AspnetCrashCourse.Schema.Orders
{
    public static class Statuses
    {
        public enum PaymentStatus
        {
            Declined,
            Due,
            Pending,
            Approved
        }

        public enum OrderStatus
        {
            Pending,
            Received,
            Fulfilled,
            Shipped,
            Complete,
            Canceled
        }
    }
}
