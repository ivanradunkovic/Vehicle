using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineMuseum.Models.Common;
using OnlineMuseum.Repository.Common;
using OnlineMuseum.Services.Common;
using OnlineMuseum.Repository;
using OnlineMuseum.Models;

namespace OnlineMuseum.Services
{
    /// <summary>
    /// Vehicle service class.
    /// </summary>
    public class VehicleService: IVehicleService
    {
        private IVehicleRepository vehicleRepository;

        public VehicleService()
        {
            vehicleRepository = new VehicleRepository();
        }

        public async Task<IVehicleModel> GetOneVehicleAsync(Guid id)
        {
            return await vehicleRepository.GetOneVehicleAsync(id);
        }

        public async Task<IEnumerable<IVehicleModel>> GetAllVehiclesAsync()
        {
            return await vehicleRepository.GetAllVehiclesAsync();
        }

        public async Task<IEnumerable<IVehicleModel>> GetAllVehiclesInCategory(Guid id)
        {
            return await vehicleRepository.GetAllVehiclesInCategory(id);
        }

        public async Task NewVehicleAsync(VehicleModel vehicleModel)
        {
            await vehicleRepository.NewVehicleAsync(vehicleModel);
        }

        public async Task UpdateBaseAsync()
        {
            await vehicleRepository.UpdateBaseAsync();
        }

        public async Task  DeleteVehicleAsync(Guid id)
        {
            await vehicleRepository.DeleteVehicleAsync(id);
        }

        public async Task<IEnumerable<IVehicleCategory>> GetAllCategoriesAsync()
        {
            return await vehicleRepository.GetAllCategoriesAsync();
        }

        public async Task<IVehicleCategory> GetOneCategory(Guid id)
        {
            return await vehicleRepository.GetOneCategory(id);
        }

    }
}
