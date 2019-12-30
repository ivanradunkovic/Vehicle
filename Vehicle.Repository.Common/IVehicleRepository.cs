using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle.Models.Common;
using Vehicle.Common;

namespace Vehicle.Repository.Common
{
    // Vehicle repository interface.
    public interface IVehicleRepository
    {
        // Gets one vehicle.
        // <param name="id">Id.</param>
        // <returns>One vehicle.</returns>
        Task<IVehicleModel> GetVehicleAsync(Guid id);

        // Gets vehicles.
        // <param name="paging">Paging.</param>
        // <param name="filterVehicle">Filter vehicle.</param>
        // <param name="sorting">Sorting.</param>
        // <returns>Vehicles.</returns>
        Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting);

        // Instert new vehicle.
        // <param name="vehicleModel">Vehicle model.</param>
        // <returns>Updates database.</returns>
        Task InsertVehicleAsync(IVehicleModel vehicleModel);

        // Upade vehicles.
        // <param name="vehicleModel">Vehicle model.</param>
        // <returns>Updates database.</returns>
        Task UpdateVehicleAsync(IVehicleModel vehicleModel);

        // Delete vehicle.
        // <param name="id">Id.</param>
        // <returns>Updated base.</returns>
        Task DeleteVehicleAsync(Guid id);
    }
}
