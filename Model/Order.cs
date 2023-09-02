namespace KonicaTracking.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Descritpcion { get; set; }
        public Vehicle AssignedVehicle { get; set; }
        public Ubicacion CurrentLocationn { get; set; }
    }
}
