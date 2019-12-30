using System;
using System.Data.Entity;
using Vehicle.DAL.Entities;

namespace Vehicle.DAL
{
    public class VehicleDbInitializer: DropCreateDatabaseIfModelChanges<VehicleContext>
    {
        protected override void Seed(VehicleContext context)
        {
            var BMW = new VehicleMake()
            {
                Id = Guid.NewGuid(),
                Name = "BMV",
                Abrv = "BMW",
            };
            context.VehicleMakes.Add(BMW);

            var Volkswagen = new VehicleMake()
            {
                Id = Guid.NewGuid(),
                Name = "Volkswagen",
                Abrv = "VW"
            };
            context.VehicleMakes.Add(Volkswagen);

            var MercedesBenz = new VehicleMake()
            {
                Id = Guid.NewGuid(),
                Name = "Mercedes-Benz",
                Abrv = "Mercedes"
            };
            context.VehicleMakes.Add(MercedesBenz);

            var GeneralMotors = new VehicleMake()
            {
                Id = Guid.NewGuid(),
                Name = "General Motors",
                Abrv = "GM"
            };
            context.VehicleMakes.Add(GeneralMotors);                      

            for (int i = 0; i < 15; i++)
            {
                var Car1 = new VehicleModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "BMW X5",
                    Abrv = "X5",                   
                    VehicleMakeId = BMW.Id,                   
                };

                var Car2 = new VehicleModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Volkswagen Gold",
                    Abrv = "Golf",                    
                    VehicleMakeId = Volkswagen.Id,                   
                };

                context.VehicleModels.Add(Car1);
                context.VehicleModels.Add(Car2);
            }

            base.Seed(context);
        }
    }
}
