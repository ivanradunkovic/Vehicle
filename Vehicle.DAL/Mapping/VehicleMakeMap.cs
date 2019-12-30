using Vehicle.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Vehicle.DAL.Mapping
{
    public class VehicleMakerMap: EntityTypeConfiguration<VehicleMake>
    {
        public VehicleMakerMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Abrv);
            this.Property(t => t.Name).IsRequired();
            this.ToTable("VehicleMakes");
        }

    }
}
