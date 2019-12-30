using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Data.Entity;
using System.Threading.Tasks;
using PagedList;
using AutoMapper;
using Vehicle.DAL;
using Vehicle.Common;
using Vehicle.Models;
using Vehicle.Models.Common;
using Vehicle.Repository.Mapping;
using Vehicle.Repository.Common;

namespace Vehicle.Repository
{
    // Vehicle repository class.
    public class VehicleRepository: IVehicleRepository
    {

        // Vehicle context field
        private VehicleContext vehicleContext;


        // Mapper.
        private IMapper mapper;

        #region constructor

        // Vehicle repository constructor.
        public VehicleRepository()
        {
            vehicleContext = new VehicleContext();
            AutoMapperMaps.ConfigureMapping();
            mapper = AutoMapperMaps.GetMapper();
        }

        #endregion

        #region Methods  

        // Gets one vehicle.
        // <param name="id">Id.</param>
        // <returns>One vehicle.</returns>
        public async Task<IVehicleModel> GetVehicleAsync(Guid id)
        {
            return mapper.Map<VehicleModelPoco>(await vehicleContext.VehicleModels.FindAsync(id));
        }

        // Gets vehicles.
        // <param name="paging">Paging.</param>
        // <param name="filterVehicle">Filter vehicle.</param>
        // <param name="sorting">Sorting.</param>
        // <returns>Vehicles.</returns>
        public async Task<IEnumerable<IVehicleModel>> GetVehiclesAsync(IPagingParameters paging, IVehicleFilter filterVehicle, ISortingParameters sorting)
        {
            var listOfVehicles = await vehicleContext.VehicleModels.ToListAsync();

            var filteredListOfVehicles = listOfVehicles                
                .Where(item => String.IsNullOrEmpty(filterVehicle.FindVehicle) ? item != null : item.Name.Contains(filterVehicle.FindVehicle))
                .Where(item => filterVehicle.MakeId == Guid.Empty ? item != null : item.VehicleMakeId == filterVehicle.MakeId);

            var sortedList = filteredListOfVehicles.OrderBy(sorting.SortField + " " + sorting.SortOrder);
            var mappedList = mapper.Map<List<VehicleModelPoco>>(sortedList);
            var pagedList = mappedList.ToPagedList(paging.PageNumber, paging.PageSize);
            var pagedListOfVehicles = new StaticPagedList<VehicleModelPoco>(pagedList, pagedList.GetMetaData());

            return pagedListOfVehicles;
        }

        // Instert new vehicle.
        // <param name="vehicleModel">Vehicle model.</param>
        // <returns>Updates database.</returns>
        public Task InsertVehicleAsync(IVehicleModel vehicleModel)
        {
            vehicleModel.Id = Guid.NewGuid();
            vehicleModel.Abrv = vehicleModel.Name.Substring(0, 3);
            vehicleContext.VehicleModels.Add(mapper.Map<DAL.Entities.VehicleModel>(vehicleModel));

            return vehicleContext.SaveChangesAsync();
        }

        // Upade vehicles.
        // <param name="vehicleModel">Vehicle model.</param>
        // <returns>Updates database.</returns>
        public Task UpdateVehicleAsync(IVehicleModel vehicleModel)
        {
            mapper.Map<DAL.Entities.VehicleModel>(vehicleModel);
            return vehicleContext.SaveChangesAsync();
        }

        // Delete vehicle.
        // <param name="id">Id.</param>
        // <returns>Updated base.</returns>
        public Task DeleteVehicleAsync(Guid id)
        {
            var oneVehicle = vehicleContext.VehicleModels.Find(id);
            vehicleContext.VehicleModels.Remove(oneVehicle);

            return vehicleContext.SaveChangesAsync();
        }

        #endregion
    }
}
