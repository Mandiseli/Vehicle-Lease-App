using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VehicleLeaseApp.Models;


namespace VehicleLeaseApp.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        [Required]
        public string Manufacturer { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; } = new Supplier();

        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; } = new Branch();

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; } = new Client();

        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; } = new Driver();
    }
}
