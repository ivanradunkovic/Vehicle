using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle.Models.Common;

namespace Vehicle.Repository.Common
{
    // Make repository interface.
    public interface IMakeRepository
    {
        // Gets one make.
        // <param name="id">Id.</param>
        // <returns>Maker.</returns>
        Task<IVehicleMake> GetMakeAsync(Guid id);

        // Gets all makes.
        // </summary>
        // <returns>Makers.</returns>
        Task<IEnumerable<IVehicleMake>> GetMakesAsync();
    }
}
