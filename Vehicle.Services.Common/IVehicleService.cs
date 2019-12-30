using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle.Models;
using Vehicle.Common;
using Vehicle.Models.Common;

namespace Vehicle.Services.Common
{
    // Vehicle service interface.
    public interface IVehicleService
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

        // Inserts new vehicle.
        // <param name="vehicleModel">Vehicle model.</param>
        // <returns>Updated database.</returns>
        Task InsertVehicleAsync(VehicleModelPoco vehicleModel);

        // Update database.
        // <param name="vehicleModel">Vehicle model.</param>
        // <returns>Updated database.</returns>
        Task UpdateBaseAsync(IVehicleModel vehicleModel);

        // Deletes vehicle.
        // <param name="id">Id.</param>
        // <returns>Updated database.</returns>
        Task DeleteVehicleAsync(Guid id);
    }
}
