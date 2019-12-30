using Vehicle.DAL.Entities;
using Vehicle.Models;
using Vehicle.Models.Common;

using AutoMapper;

namespace Vehicle.Repository.Mapping
{
    public class Mappings: Profile
    {
        protected override void Configure()
        {
            CreateMap<VehicleModel, VehicleModelPoco>().ReverseMap();
            CreateMap<VehicleModel, IVehicleModel>().ReverseMap();
            CreateMap<IVehicleModel, VehicleModelPoco>().ReverseMap();

            CreateMap<VehicleMake, VehicleMakePoco>().ReverseMap();
            CreateMap<VehicleMake, IVehicleMake>().ReverseMap();
            CreateMap<IVehicleMake, VehicleMakePoco>().ReverseMap();

        }
    }
}
