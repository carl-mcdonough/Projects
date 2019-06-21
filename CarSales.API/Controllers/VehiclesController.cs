using System.Threading.Tasks;
using CarSales.API.Data;
using CarSales.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarSales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly ICarSalesData _context;

        public VehiclesController(ICarSalesData context)
        {
            _context = context;
        }

        // GET api/vehicles
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            var vehicles = await _context.GetVehicles();

            return Ok(vehicles);
        }

        // GET api/vehicles/vehicletypes
        [HttpGet("vehicletypes")]
        public async Task<IActionResult> GetVehicleTypes()
        {
            var vehicletypes = await _context.GetVehicleTypes();

            return Ok(vehicletypes);
        }

        // GET api/vehicles/vehiclemakes/1
        [HttpGet("vehiclemakes/{id}")]
        public async Task<IActionResult> GetVehicleMakes(int id)
        {
            var vehiclemakes = await _context.GetVehicleMakes(id);

            return Ok(vehiclemakes);
        }

        // GET api/vehicles/vehiclemodels
        [HttpGet("vehiclemodels/{id}")]
        public async Task<IActionResult> GetVehicleModels(int id)
        {
            var vehiclemodels = await _context.GetVehicleModels(id);

            return Ok(vehiclemodels);
        }

        // GET api/vehicles/vehiclebodytypes
        [HttpGet("vehiclebodytypes/{id}")]
        public async Task<IActionResult> GetVehicleBodyTypes(int id)
        {
            var vehiclebodytypes = await _context.GetVehicleBodyTypes(id);

            return Ok(vehiclebodytypes);
        }

        // POST api/vehicles
        [HttpPost("addvehicle")]
        public async Task<IActionResult> AddVehicle(Vehicle vehicle)
        {
            var createdVehicle = await _context.AddVehicle(vehicle);

            return Ok(createdVehicle);
        }
    }
}