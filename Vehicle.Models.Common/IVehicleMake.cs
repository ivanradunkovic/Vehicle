using System;

namespace Vehicle.Models.Common
{
    // Vehicle make interface.
    public interface IVehicleMake
    {

        // Gest or sets Id.
        Guid Id { get; set; }

        /// Gest or sets name.
        string Name { get; set; }

        // Gets or sets abreviaton.
        string Abrv { get; set; }
    }
}
