using System.Data.Entity;
using Vehicle.DAL.Entities;
using Vehicle.DAL.Mapping;

namespace Vehicle.DAL
{
    public class VehicleContext: DbContext
    {
        public VehicleContext()
            : base("VehicleDb")
        {
            Database.SetInitializer<VehicleContext>(new VehicleDbInitializer());
        }

        public virtual DbSet<VehicleModel> VehicleModels { get; set; }

        public virtual DbSet<VehicleMake> VehicleMakes { get; set; }      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {           
            modelBuilder.Configurations.Add(new VehicleMakerMap());
            modelBuilder.Configurations.Add(new VehicleModelMap());
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
