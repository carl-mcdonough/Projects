using System.ComponentModel.DataAnnotations;

namespace CarSales.API.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleType VehicleType { get; set; }
        [Required]
        public int VehicleTypeId { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        public string Engine { get; set; } //nullable if not car
        public int Doors { get; set; } //nullable if not car
        public int Wheels { get; set; } //nullable if not car
        public string BodyType { get; set; } //nullable if not car


        //future properties for other vehicle types //nullable
        // public int SailArea { get; set; }  //boat
        // public int Displacement { get; set; }  //boat
        // public string Frame { get; set; }  //bike
        // public string Fork { get; set; }  //bike
    }
}