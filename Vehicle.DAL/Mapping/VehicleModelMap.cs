using Vehicle.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vehicle.DAL.Mapping
{
    public class VehicleModelMap: EntityTypeConfiguration<VehicleModel>
    {
        public VehicleModelMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Abrv);
            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.VehicleMakeId).IsRequired();

            this.ToTable("VehicleModels");

            this.HasRequired(t => t.VehicleMake).WithMany(c => c.VeehicleModels)
                .HasForeignKey(t => t.VehicleMakeId).WillCascadeOnDelete(false);           
        }
        
    }
}
