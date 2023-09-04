using KonicaTracking.Data.Model;
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
                Latitude = location.Latitude,
                Longitude = location.Longitude
            });
            return NoContent();
        }

    }

}
