using System;

namespace Vehicle.DAL.Entities
{
    public class VehicleModel
    {
       // Gets or sets Id.
        public Guid Id { get; set; }

        // Gets or sets model of the vehicle.
        public string Name { get; set; }

        // Gets or sets abreviaton.
        public string Abrv { get; set; }
      
        public Guid VehicleMakeId { get; set; }
      
        public virtual VehicleMake VehicleMake { get; set; }

    }
}
