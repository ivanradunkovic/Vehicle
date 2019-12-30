using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vehicle.Repository;
using Vehicle.Models.Common;
using Vehicle.Repository.Common;
using Vehicle.Services.Common;

namespace Vehicle.Services
{

    // Make service class.
    public class MakeService : IMakeService
    {

        // Make repository.
        private IMakeRepository makeRepository;

        #region constructor

        // Make service constructor.
        public MakeService()
        {
            makeRepository = new MakeRepository();
        }

        #endregion

        #region Public methods

        // Gets all makes.
        // <returns>Makers.</returns>
        public async Task<IEnumerable<IVehicleMake>> GetMakesAsync()
        {
            return await makeRepository.GetMakesAsync();
        }

        // Gets one make.
        // <param name="id">Id.</param>
        // <returns>One maker.</returns>
        public async Task<IVehicleMake> GetMakeAsync(Guid id)
        {
            return await makeRepository.GetMakeAsync(id);
        }

        #endregion

    }
}
