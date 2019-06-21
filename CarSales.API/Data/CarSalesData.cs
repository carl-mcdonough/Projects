using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSales.API.Model;
using Microsoft.EntityFrameworkCore;

namespace CarSales.API.Data
{
    public class CarSalesData : ICarSalesData
    {
        private readonly DataContext _context;

        public CarSalesData(DataContext context)
        {
            _context = context;
        }
        public async Task<Vehicle> AddVehicle(Vehicle vehicle)
        {
            await _context.Vehicles.AddAsync(vehicle);
            await _context.SaveChangesAsync();

            return vehicle;
        }

        public async Task<IEnumerable<VehicleBodyType>> GetVehicleBodyTypes(int id)
        {
            var ModelName = _context.VehicleModels
            .Where(x => x.Id == id)
            .Select(vehicle => vehicle.Model)
            .FirstOrDefault();

            var result = _context.VehicleModels
            .Where(i => i.Model == ModelName)
            .Select(vehicle => vehicle.VehicleBodyTypeId);

            var vehicleBodyTypes = await _context.VehicleBodyTypes
            .Where(x => result.Contains(x.Id))
            .ToListAsync();

            return vehicleBodyTypes;
        }

        public async Task<IEnumerable<VehicleMake>> GetVehicleMakes(int id)
        {
            var vehicleMakes = await _context.VehicleMakes
            .Include(v => v.VehicleType)
            .Where(i => i.VehicleTypeId == id).ToListAsync();

            return vehicleMakes;
        }

        public async Task<IEnumerable<VehicleModel>> GetVehicleModels(int id)
        {
            var vehicleModels = await _context.VehicleModels
            .Include(m => m.VehicleMake)
            .Include(b => b.VehicleBodyType)
            .Where(m => m.VehicleMake.Id == id)
            .GroupBy(m => m.Model)
            .Select(group => group.First())
            .ToListAsync();

            return vehicleModels;
        }

        public async Task<IEnumerable<Vehicle>> GetVehicles()
        {
            var vehicles = await _context.Vehicles.ToListAsync();

            return vehicles;
        }

        public async Task<IEnumerable<VehicleType>> GetVehicleTypes()
        {
            var vehicleTypes = await _context.VehicleTypes.ToListAsync();

            return vehicleTypes;
        }
    }
}