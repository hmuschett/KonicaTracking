using KonicaTracking.Data.Contracts;
using KonicaTracking.Data.Models;
using KonicaTracking.Models.Request;
using KonicaTracking.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace KonicaTracking.Controllers
{
    /// <summary>
    /// Controller with orders endpoints.
    /// </summary>
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : Controller
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly ILogger<OrdersController> _logger;

        /// <summary>
        /// Initialize a new instance of <see cref="OrdersController"/> class.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="ordersRepository"></param>
        public OrdersController(ILogger<OrdersController> logger,IOrdersRepository ordersRepository)
        {
            _logger = logger;
            _ordersRepository = ordersRepository;
        }

        /// <summary>
        /// Adds a new order to the system.
        /// </summary>
        /// <param name="newOrder">The order details to be added.</param>
        /// <returns>A message response indicating the result of the operation.</returns>
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<MessageResponse<String>>> AddOrder([FromBody] OrderRequest newOrder)
        {
            try
            {
                _logger.LogDebug($"Retrive all orders");
                _logger.LogError($"Unhandled error when trying to save a new order. Message:");
                if (await _ordersRepository.CreateOrderAsync(newOrder))
                    return Ok(MessageResponse<String>.Success($"The new order has been saved."));
                return Ok(MessageResponse<String>.Fail($"The order could not be saved and the cause is unknown."));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Unhandled error when trying to save a new order. Message: {ex.Message}");
                return BadRequest(MessageResponse<String>.Fail($"The order could not be saved."));
            }
        }

        /// <summary>
        /// Deletes an existing order based on the provided ID.
        /// </summary>
        /// <param name="id">The ID of the order to be deleted.</param>
        /// <returns>An IActionResult indicating the result of the delete operation.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var result = await _ordersRepository.DeleteOrderAsync(id);
            if (!result)
            {
                return NotFound(MessageResponse<String>.Success("Order not found."));
            }

            return NoContent(); // Devuelve un 204 No Content cuando la eliminación es exitosa.
        }

        /// <summary>
        /// Assigns a vehicle to an order.
        /// </summary>
        /// <param name="orderId">The ID of the order.</param>
        /// <param name="vehicleId">The ID of the vehicle to assign.</param>
        /// <returns>An IActionResult indicating the result of the assignment.</returns>
        [HttpPut("{orderId}/assign-vehicle/{vehicleId}")]
        public async Task<IActionResult> AssignVehicleToOrder(int orderId, int vehicleId)
        {
            var result = await _ordersRepository.AssignVehicleToOrderAsync(orderId, vehicleId);
            if (result)
            {
                return Ok(MessageResponse<String>.Success("Vehicle assigned to order successfully." ));
            }
            return NotFound(MessageResponse<String>.Success("Order not found or failed to assign vehicle."));
        }

        /// <summary>
        /// Retrieves the order and its associated vehicle's location using the order ID.
        /// </summary>
        /// <param name="orderId">The ID of the order.</param>
        /// <returns>An IActionResult with the order and vehicle location or an error message.</returns>
        [HttpGet("{orderId}/location")]
        public async Task<IActionResult> GetOrderAndVehicleLocation(int orderId)
        {
            var (order, vehicleLocation) = await _ordersRepository.GetOrderAndVehicleLocationAsync(orderId);
            if (order == null || vehicleLocation == null)
            {
                return NotFound(MessageResponse<String>.Success("Order or vehicle not found." ));
            }

            return Ok(new
            {
                Order = order,
                VehicleLocation = vehicleLocation
            });
        }
    }
}
