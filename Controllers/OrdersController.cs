using KonicaTracking.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace KonicaTracking.Controllers
{

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
                OrderLocation = order.AssignedVehicle.CurrentLocation,
                Vehicle = order.AssignedVehicleId
            });
        }
    }
}
