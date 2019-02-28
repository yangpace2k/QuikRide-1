// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;
using CGH.QuikRide.DTO.QR;

namespace CGH.QuikRide.DTO.QR
{
	public static class DemoReservation
	{
		public static System.Guid SampleReservationId0000 = Guid.Parse("ce3ac458-1153-4c97-858e-b04ef40d1031");
		public static System.Guid SampleReservationId0100 = Guid.Parse("2bab19f8-f3cf-4bcd-92bd-6093e23c9479");

		public static Reservation SampleReservation00
		{
			get
			{
				return new Reservation()
				{
					ReservationId = SampleReservationId0100,
					UserId = 0,
					PickUpLocationId = Guid.Parse("65034ad8-da04-46e3-bea9-76a573e8eff6"),
					DestinationLocationId = Guid.Parse("8eda9b52-da21-40ee-9977-194cb0a04a20"),
					ReservationRequestOptionId = 0,
					ReservationStatusTypeId = 0,
					ReservationCancellationReasonId = 0,
					NumberOfAdults = 0,
					NumberOfChildren = 0,
					NumberOfBabies = 0,
					NumberOfWheelchairs = 0,
					NumberOfBikes = 0,
					PersonalCareAttendantIncluded = false,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}
		public static Reservation SampleReservation01
		{
			get
			{
				return new Reservation()
				{
					ReservationId = SampleReservationId0100,
					UserId = 0,
					PickUpLocationId = Guid.Parse("187a70fc-867e-4083-a4c2-1da751343d2a"),
					DestinationLocationId = Guid.Parse("fa49d62a-50c4-4f4a-a3b6-84717a3cdb61"),
					ReservationRequestOptionId = 0,
					ReservationStatusTypeId = 0,
					ReservationCancellationReasonId = 0,
					NumberOfAdults = 0,
					NumberOfChildren = 0,
					NumberOfBabies = 0,
					NumberOfWheelchairs = 0,
					NumberOfBikes = 0,
					PersonalCareAttendantIncluded = false,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}

	}
}
