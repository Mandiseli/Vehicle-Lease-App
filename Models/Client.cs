using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VehicleLeaseApp.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Address { get; set; }

        public virtual ICollection<Client>? Vehicles { get; set; }
    }
}
