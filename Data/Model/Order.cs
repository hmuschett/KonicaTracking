namespace KonicaTracking.Data.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Descritpcion { get; set; }
        public int AssignedVehicleID { get; set; }
        public OrderStatus Status { get; set; }
    }
    public enum OrderStatus
    {
        Placed,
        InTransit,
        Delivered,
        Canceled
    }
}
