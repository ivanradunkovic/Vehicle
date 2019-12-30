using System;
using System.Collections.Generic;

namespace Vehicle.DAL.Entities
{
    public class VehicleMake
    {
        // Gest or sets Id.
        public Guid Id { get; set; }

        // Gest or sets name.

        public string Name { get; set; }

        // Gets or sets abreviaton.
        public string Abrv { get; set; }

        public ICollection<VehicleModel> VeehicleModels { get; set; }
    }
}
