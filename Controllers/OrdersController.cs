﻿using KonicaTracking.Data.Contracts;
using KonicaTracking.Data.Models;
using KonicaTracking.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace KonicaTracking.Controllers
{
    public record NewOrder
    {
        /// <summary>
        /// Gets or sets the description of the order.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the id vehicle.
        /// </summary>
        public int AssignedVehicleId { get; set; }

        /// <summary>
        /// Gets or sets the status of the order.
        /// </summary>
        public OrderStatus Status { get; private set; } = OrderStatus.Placed;
    }

    /// <summary>
    /// Controller with orders endpoints.
    /// </summary>
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : Controller
    {
        private readonly IOrdersRepository _ordersRepository;

        /// <summary>
        /// Initialize a new instance of <see cref="OrdersController"/> class.
        /// </summary>
        /// <param name="loggerManager"></param>
        /// <param name="ordersRepository"></param>
        public OrdersController( IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<MessageResponse<String>>> AddOrder([FromBody] OrderResponse newOrder)
        {
            try
            {
                if (await _ordersRepository.CreateOrderAsync(newOrder)) return Ok(MessageResponse<String>.Success($"Se ha guardado la nueva orden."));
                return Ok(MessageResponse<String>.Fail($"No se ha podido guardar el pedido y se desconoce la causa."));
            }
            catch (Exception ex)
            {
                return BadRequest(MessageResponse<String>.Fail($"No se ha podido guardar el pedido."));
            }
        }
    }
}
