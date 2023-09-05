using KonicaTracking.Data.Contracts;
using KonicaTracking.Data.Models;
using KonicaTracking.Models.Response;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace KonicaTracking.Controllers
{
    [ApiController]
    [Route("api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IVehiclesRepository _vehiclesRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehiclesController"/> class.
        /// </summary>
        /// <param name="vehiclesRepository">The repository for retrieving information about vehicles.</param>
        public VehiclesController(IVehiclesRepository vehiclesRepository)
        {
            _vehiclesRepository = vehiclesRepository;
        }

        /// <summary>
        /// Retrieves a collection of all vehicles asynchronously.
        /// </summary>
        /// <returns>An asynchronous task that represents the action's result, which contains a collection of vehicles.</returns>
        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<MessageResponse<ICollection<VehicleResponse>>>> AllVehiclesAsync()
        {
            
            try
            {
                // Repository response.
                var repositoryResponse = await _vehiclesRepository.GetAllAsync();

                // ICollection to response.
                ICollection<VehicleResponse> vehicles = new List<VehicleResponse>();
                repositoryResponse.ToList().ForEach(v =>
                {
                    vehicles.Add(new VehicleResponse(v));
                });

                return Ok(MessageResponse<ICollection<VehicleResponse>>.Success(vehicles));
            }
            catch (Exception ex)
            {
                //ToDo: Implementar el logger
               
                return BadRequest(MessageResponse<String>.Fail("No se pudo obtener el listado de vehiculos."));
            }
        }
    }
}
