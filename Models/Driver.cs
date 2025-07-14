using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VehicleLeaseApp.Models
{
    public class Driver
    {
        public int DriverId { get; set; }

        [Required]
        public string? FullName { get; set; }

        public string? LicenseNumber { get; set; }

        public virtual ICollection<Vehicle>? Vehicles { get; set; }
    }
}
