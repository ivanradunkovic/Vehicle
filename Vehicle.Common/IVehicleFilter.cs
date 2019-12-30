using System;
namespace Vehicle.Common
{
    
    // Vehicle filter interface.
 
    public interface IVehicleFilter
    {
               
        // Gets or sets find vehicle.
   
        string FindVehicle { get; set; }

        // Gets or sets make id.
        Guid? MakeId { get; set; }

    }
}
