// <auto-generated> - Template:SqliteModelData, Version:1.1, Id:c5caad15-b3be-4443-87d8-7cabde59f7b0
using SQLite;

namespace CGH.QuikRide.Xam.ModelData.QR
{
	[Table("ReservationRequest")]
	public partial class ReservationRequest
	{
		public string CreatedBy { get; set; }
		public System.DateTime CreatedUtcDate { get; set; }
		public int DataVersion { get; set; }
		public System.Guid DestinationLocationId { get; set; }
		public bool IsDeleted { get; set; }
		public string ModifiedBy { get; set; }
		public System.DateTime ModifiedUtcDate { get; set; }
		public int NumberOfAdults { get; set; }
		public int NumberOfBabies { get; set; }
		public int? NumberOfBikes { get; set; }
		public int NumberOfChildren { get; set; }
		public int? NumberOfWheelchairs { get; set; }
		public bool PassengerRequiresAssistance { get; set; }
		public bool PersonalCareAttendantIncluded { get; set; }
		public System.Guid PickupLocationId { get; set; }
		public System.Guid? ReplacesReservationId { get; set; }
		public System.DateTime? RequestedArrivalEnd { get; set; }
		public System.DateTime? RequestedArrivalStart { get; set; }
		public System.DateTime? RequestedPickupEnd { get; set; }
		public System.DateTime? RequestedPickupStart { get; set; }
		public System.Guid? ReservationId { get; set; }
		public int? ReservationRequestCancellationReasonTypeId { get; set; }

		[PrimaryKey]
		public System.Guid ReservationRequestId { get; set; }

		public int ReservationRequestStatusTypeId { get; set; }
		public int UserId { get; set; }
	}
}
