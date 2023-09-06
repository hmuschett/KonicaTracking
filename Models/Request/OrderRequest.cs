using KonicaTracking.Data.Models;
using KonicaTracking.Services.Models;

namespace KonicaTracking.Models.Request
{
    public class OrderRequest : IOrder
    {
        public string Description { get; set; }
        public int? AssignedVehicleId { get; set; }
        public IVehicle AssignedVehicle { get; set; }
        public OrderStatus Status { get; set; }
    }


}
