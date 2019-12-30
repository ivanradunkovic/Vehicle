using System;

namespace Vehicle.Models.Common
{
    /// Vehicle model interface.
    public interface IVehicleModel
    {
        // Gets or sets Id.
        Guid Id { get; set; }

        // Gets or sets model of the vehicle.
        string Name { get; set; }

        // Gets or sets abreviaton.
        string Abrv { get; set; }       
       
        Guid VehicleMakeId { get; set; }

        // Gets or sets make of the vehicle.
        IVehicleMake VehicleMake { get; set; }
    }
}
