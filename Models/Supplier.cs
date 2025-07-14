using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VehicleLeaseApp.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? ContactInfo { get; set; }

        public virtual ICollection<Supplier>? Vehicles { get; set; }
    }
}
