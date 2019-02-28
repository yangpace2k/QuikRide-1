// <auto-generated> - Template:DTO, Version:1.1, Id:58fa7ee2-89f7-41e6-85ed-8d4482653990
namespace CGH.QuikRide.DTO.QR
{
	public partial class Vehicle
	{
		public Vehicle()
		{
			InitializePartial();
		}

		public int VehicleId { get; set; } // Primary key
		public int VehicleTypeId { get; set; }
		public int VehicleStatusTypeId { get; set; }
		public double? Latitude { get; set; }
		public double? Longitude { get; set; }
		public string Vin { get; set; }
		public string LicensePlateNumber { get; set; }
		public System.DateTime StartDateInService { get; set; }
		public System.DateTime? EndDateInService { get; set; }
		public int DataVersion { get; set; }
		public System.DateTime CreatedUtcDate { get; set; }
		public string CreatedBy { get; set; }
		public System.DateTime ModifiedUtcDate { get; set; }
		public string ModifiedBy { get; set; }
		public bool IsDeleted { get; set; }
		public virtual System.Collections.Generic.ICollection<Driver> Drivers { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.ICollection<Ride> Rides { get; set; } // Many to many mapping
		public virtual System.Collections.Generic.ICollection<VehicleVehicleFeatureType> VehicleVehicleFeatureTypes { get; set; } // Many to many mapping
		public virtual VehicleStatusType VehicleStatusType { get; set; } 
		public virtual VehicleType VehicleType { get; set; } 


		partial void InitializePartial();

	}
}
