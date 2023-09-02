namespace KonicaTracking.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public List<Order> Orders { get; set; }
        public List<LocationHistory> LocationsHistory  { get; set; }
        public Location CurrentLocation { get; set; }
    }
}
