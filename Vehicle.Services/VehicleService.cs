using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle.Models;
using Vehicle.Common;
using Vehicle.Repository;
using Vehicle.Models.Common;
using Vehicle.Repository.Common;
using Vehicle.Services.Common;

namespace Vehicle.Services
{
    // Vehicle service class.
    public class VehicleService: IVehicleService
    {

        // Vehicle repository.
        private IVehicleRepository vehicleRepository;

        #region constructor

        // Vehicle service constructor.
        public VehicleService()
        {
            vehicleRepository = new VehicleRepository();         
        }

        #endregion

        #region Public methods

        // Gets one vehicle.
        // <param name="id">Id.</param>
        // <returns>One vehicle.</returns>
        public async Task<IVehicleModel> GetVehicleAsync(Guid id)
        {
            return await vehicleRepository.GetVehicleAsync(id);
        }

        // Gets vehicles.
        // <param name="paging">Paging.</param>
        // <param name="filterVehicle">Filter vehicle.</param>
        // <param name="sorting">Sorting.</param>
        // <returns>Vehicles.</returns>
        public async Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting)
        {
            return await vehicleRepository.GetVehiclesAsync(paging, filterVehicle, sorting);
        }

        // Inserts new vehicle.
        // <param name="vehicleModel">Vehicle model.</param>
        // <returns>Updated database.</returns>
        public Task InsertVehicleAsync(VehicleModelPoco vehicleModel)
        {
            return vehicleRepository.InsertVehicleAsync(vehicleModel);
        }

        // Update database.
        // <param name="vehicleModel">Vehicle model.</param>
        // <returns>Updated database.</returns>
        public Task UpdateBaseAsync(IVehicleModel vehicleModel)
        {
            return vehicleRepository.UpdateVehicleAsync(vehicleModel);
        }

        // Deletes vehicle.
        // <param name="id">Id.</param>
        // <returns>Updated database.</returns>
        public Task  DeleteVehicleAsync(Guid id)
        {
            return vehicleRepository.DeleteVehicleAsync(id);
        }

        #endregion
    }
}
