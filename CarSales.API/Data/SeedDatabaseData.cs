using System.Collections.Generic;
using System.Linq;
using CarSales.API.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CarSales.API.Data
{
    public class SeedDatabaseData
    {
        public static void SeedDBData(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DataContext>();
                context.Database.EnsureCreated();

                if(!context.VehicleTypes.Any())
                {
                    var vehicletypes = GetVehicleTypes().ToArray();
                    context.VehicleTypes.AddRange(vehicletypes);
                    context.SaveChanges();
                }

                if(!context.VehicleMakes.Any())
                {
                    var vehiclemakes = GetVehicleMakes().ToArray();
                    context.VehicleMakes.AddRange(vehiclemakes);
                    context.SaveChanges();
                }

                if(!context.VehicleBodyTypes.Any())
                {
                    var vehiclebodytypes = GetVehicleBodyTypes().ToArray();
                    context.VehicleBodyTypes.AddRange(vehiclebodytypes);
                    context.SaveChanges();
                } 

                if(!context.VehicleModels.Any())
                {
                    var vehiclemodel = GetVehicleModels().ToArray();
                    context.VehicleModels.AddRange(vehiclemodel);
                    context.SaveChanges();
                }
            }
                return;
        }

        public static List<VehicleType> GetVehicleTypes()
        {
            List<VehicleType> vehicletypes = new List<VehicleType>() {
                new VehicleType { Type = "Car" }
            };

            return vehicletypes;
        }

        public static List<VehicleMake> GetVehicleMakes()
        {
            List<VehicleMake> vehiclemake = new List<VehicleMake>() {
                new VehicleMake { Make = "Chevrolet", VehicleTypeId = 1 },
                new VehicleMake { Make = "Hyundai", VehicleTypeId = 1 },
                new VehicleMake { Make = "Land Rover", VehicleTypeId = 1 },
                new VehicleMake { Make = "Mitsubishi", VehicleTypeId = 1 },
                new VehicleMake { Make = "Toyota", VehicleTypeId = 1 }
            };

            return vehiclemake;
        }

        public static List<VehicleBodyType> GetVehicleBodyTypes()
        {
            List<VehicleBodyType> vehiclebodytype = new List<VehicleBodyType>() {
                new VehicleBodyType { BodyType = "Convertible" },
                new VehicleBodyType { BodyType = "Coupe" },
                new VehicleBodyType { BodyType = "Hatch" },
                new VehicleBodyType { BodyType = "People Mover" },
                new VehicleBodyType { BodyType = "Sedan"},
                new VehicleBodyType { BodyType = "SUV" },
                new VehicleBodyType { BodyType = "Wagon"}
            };

            return vehiclebodytype;
        }

        public static List<VehicleModel> GetVehicleModels()
        {
            List<VehicleModel> vehiclemodel = new List<VehicleModel>() {
                new VehicleModel { Model = "Accent", VehicleMakeId = 2, VehicleBodyTypeId = 3 },
                new VehicleModel { Model = "Accent", VehicleMakeId = 2, VehicleBodyTypeId = 5 },
                new VehicleModel { Model = "Alphard", VehicleMakeId = 5, VehicleBodyTypeId = 4 },
                new VehicleModel { Model = "Camaro", VehicleMakeId = 1, VehicleBodyTypeId = 1 },
                new VehicleModel { Model = "Camaro", VehicleMakeId = 1, VehicleBodyTypeId = 2 },
                new VehicleModel { Model = "Camry", VehicleMakeId = 5, VehicleBodyTypeId = 5 },
                new VehicleModel { Model = "Camry", VehicleMakeId = 5, VehicleBodyTypeId = 7 },
                new VehicleModel { Model = "Corvette", VehicleMakeId = 1, VehicleBodyTypeId = 1 },
                new VehicleModel { Model = "Corvette", VehicleMakeId = 1, VehicleBodyTypeId = 2 },
                new VehicleModel { Model = "Discovery 4", VehicleMakeId = 3, VehicleBodyTypeId = 6 },
                new VehicleModel { Model = "Elantra", VehicleMakeId = 2, VehicleBodyTypeId = 3 },
                new VehicleModel { Model = "Elantra", VehicleMakeId = 2, VehicleBodyTypeId = 5 },
                new VehicleModel { Model = "Genesis", VehicleMakeId = 2, VehicleBodyTypeId = 5 },
                new VehicleModel { Model = "Kona", VehicleMakeId = 2, VehicleBodyTypeId = 6 },
                new VehicleModel { Model = "Lancer", VehicleMakeId = 4, VehicleBodyTypeId = 2 },
                new VehicleModel { Model = "Lancer", VehicleMakeId = 4, VehicleBodyTypeId = 3 },
                new VehicleModel { Model = "Lancer", VehicleMakeId = 4, VehicleBodyTypeId = 5 },
                new VehicleModel { Model = "Lancer", VehicleMakeId = 4, VehicleBodyTypeId = 7 },
                new VehicleModel { Model = "Mirage", VehicleMakeId = 4, VehicleBodyTypeId = 5 },
                new VehicleModel { Model = "Pajero Sport", VehicleMakeId = 4, VehicleBodyTypeId = 6 },
                new VehicleModel { Model = "Range Rover Sport", VehicleMakeId = 3, VehicleBodyTypeId = 6 },
                new VehicleModel { Model = "Rav 4", VehicleMakeId = 5, VehicleBodyTypeId = 6 }
            };

            return vehiclemodel;
        }
    }
}