namespace CarSales.API.Model
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public VehicleMake VehicleMake { get; set; }
        public int VehicleMakeId { get; set; }
        public VehicleBodyType VehicleBodyType { get; set; }
        public int VehicleBodyTypeId { get; set; }
    }
}