using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoMapper;
using Vehicle.DAL;
using Vehicle.Models;
using Vehicle.Models.Common;
using Vehicle.Repository.Mapping;
using Vehicle.Repository.Common;

namespace Vehicle.Repository
{
    // Maker repository class.
    public class MakeRepository: IMakeRepository
    {

        // Vehicle context field.
        private VehicleContext vehicleContext;

        // Mapper.
        private IMapper mapper;


        #region constructor

        // Make repository constructor.
        public MakeRepository()
        {
            vehicleContext = new VehicleContext();
            AutoMapperMaps.ConfigureMapping();
            mapper = AutoMapperMaps.GetMapper();
        }

        #endregion

        // Gets all makes.
        // <returns>Makes.</returns>
        public async Task<IEnumerable<IVehicleMake>> GetMakesAsync()
        {
            return mapper.Map<IEnumerable<VehicleMakePoco>>(await vehicleContext.VehicleMakes.ToListAsync());
        }

        // Gets one make.
        // <param name="id">Id.</param>
        // <returns>Maker.</returns>
        public async Task<IVehicleMake> GetMakeAsync(Guid id)
        {
            return mapper.Map<VehicleMakePoco>(await vehicleContext.VehicleMakes.FindAsync(id));
        }
    }
}
