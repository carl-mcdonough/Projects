namespace CarSales.API.Model
{
    public class VehicleMake
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public VehicleType VehicleType { get; set; }
        public int VehicleTypeId { get; set; }
    }
}