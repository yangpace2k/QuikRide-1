// <auto-generated> - Template:DTO, Version:1.1, Id:58fa7ee2-89f7-41e6-85ed-8d4482653990
namespace CGH.QuikRide.DTO.QR
{
	public partial class RidePosition
	{
		public RidePosition()
		{
			InitializePartial();
		}

		public System.Guid RidePositionId { get; set; } // Primary key
		public System.Guid RideId { get; set; }
		public decimal Latitude { get; set; }
		public decimal Longitude { get; set; }
		public System.DateTime Ts { get; set; }
		public int DataVersion { get; set; }
		public System.DateTime CreatedUtcDate { get; set; }
		public string CreatedBy { get; set; }
		public System.DateTime ModifiedUtcDate { get; set; }
		public string ModifiedBy { get; set; }
		public bool IsDeleted { get; set; }
		public virtual Ride Ride { get; set; } 


		partial void InitializePartial();

	}
}
