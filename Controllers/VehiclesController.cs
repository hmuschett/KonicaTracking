using KonicaTracking.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KonicaTracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private static List<Vehicle> Vehicles = new List<Vehicle>();
        private static int currentVehicleId = 1;

        [HttpPost]
        public IActionResult Post(Vehicle vehicle)
        {
            vehicle.Id = currentVehicleId++;
            Vehicles.Add(vehicle);
            return Created($"api/vehicles/{vehicle.Id}", vehicle);
        }

        [HttpPut("{id}/location")]
        public IActionResult UpdateLocation(int id, Location location)
        {
            var vehicle = Vehicles.FirstOrDefault(v => v.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            vehicle.CurrentLocation = location;
            vehicle.LocationHistory.Add(new LocationHistory
            {
                Id = vehicle.LocationHistory.Count + 1,
                Date = DateTime.Now,
                Location = location
            });
            return NoContent();
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> Orders = new List<Order>();
        private static int currentOrderId = 1;

        [HttpPost]
        public IActionResult Post(Order order)
        {
            order.Id = currentOrderId++;
            Orders.Add(order);
            return Created($"api/orders/{order.Id}", order);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            Orders.Remove(order);
            return NoContent();
        }

        [HttpGet("{id}/location")]
        public IActionResult GetLocation(int id)
        {
            var order = Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(new
            {
                OrderLocation = order.CurrentLocation,
                Vehicle = order.AssignedVehicle
            });
        }
    }
}
