using System;
using Vehicle.Models.Common;

namespace Vehicle.Models
{ 
    // Vehicle make class.

    public class VehicleMakePoco: IVehicleMake
    {

        // Gest or sets Id.
        public Guid Id { get; set; }

        // Gest or sets name.
        public string Name { get; set; }

        // Gets or sets abreviaton.
        public string Abrv { get; set; }
    }
}
