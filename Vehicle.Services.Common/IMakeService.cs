using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle.Models.Common;

namespace Vehicle.Services.Common
{

    // Make service interface.
    public interface IMakeService
    {
        // Gets all makes.
        // <returns>Makes.</returns>
        Task<IEnumerable<IVehicleMake>> GetMakesAsync();

        // Gets one make.
        // <param name="id">Id.</param>
        // <returns>One maker.</returns>
        Task<IVehicleMake> GetMakeAsync(Guid id);

    }
}
