using System;
using System.ComponentModel.DataAnnotations;
using Vehicle.Models.Common;

namespace Vehicle.Models
{
    // Vehicle model class.
    public class VehicleModelPoco: IVehicleModel
    {

        // Gets or sets Id.
        public Guid Id { get; set; }


        // Gets or sets model of the vehicle.
        [Required(ErrorMessage = "Enter name of the vehicle")]
        public string Name { get; set; }

        // Gets or sets abreviaton.
        public string Abrv { get; set; }
          
        public Guid VehicleMakeId { get; set; }

        public virtual IVehicleMake VehicleMake { get; set; }

    }
}
