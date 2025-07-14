using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VehicleLeaseApp.Models
{
    public class Branch
    {
        public int BranchId { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Location { get; set; }

        public virtual ICollection<Vehicle>? Vehicles { get; set; }
    }
}
