using System.Collections.Generic;
using System.Threading.Tasks;
using CarSales.API.Model;

namespace CarSales.API.Data
{
    public interface ICarSalesData
    {
        Task<IEnumerable<Vehicle>> GetVehicles();
        Task<IEnumerable<VehicleType>> GetVehicleTypes();
        Task<IEnumerable<VehicleMake>> GetVehicleMakes(int id);
        Task<IEnumerable<VehicleModel>> GetVehicleModels(int id);
        Task<IEnumerable<VehicleBodyType>> GetVehicleBodyTypes(int id);
        Task<Vehicle> AddVehicle(Vehicle vehicle);
    }
}