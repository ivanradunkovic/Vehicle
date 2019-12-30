using System;

namespace Vehicle.Common
{
    // Vehicle filter class.
    public class VehicleFilter : IVehicleFilter
    {
        #region constructor

        // Vehicle filter constructor.   
        // <param name="findVehicle">Find vehicle.</param>
        // <param name="makeId">Maker id.</param>
        public VehicleFilter(Guid id, string findVehicle, Guid? makeId)
        {          
            this.FindVehicle = findVehicle;
            this.MakeId = makeId.HasValue ? makeId.Value : Guid.Empty;
        }

        #endregion

        #region properties 

        // Gets or sets find vehicle.
        public string FindVehicle { get; set; }

        // Gets or sets make id.
        public Guid? MakeId { get; set; }

        #endregion
    }
}
