namespace KonicaTracking.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<LocationHistory> LocationHistory { get; set; } = new List<LocationHistory>();
        public Location CurrentLocation { get; set; }
    }
}
