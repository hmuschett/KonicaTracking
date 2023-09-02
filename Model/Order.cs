namespace KonicaTracking.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Descritpcion { get; set; }
        public Vehicle AssignedVehicle { get; set; }
        public Location CurrentLocation { get; set; }
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
