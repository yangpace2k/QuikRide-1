// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;
using CGH.QuikRide.DTO.QR;

namespace CGH.QuikRide.DTO.QR
{
	public static class DemoReservationRequestOption
	{
		public static int SampleReservationRequestOptionId0000 = 1162861498;
		public static int SampleReservationRequestOptionId0100 = 1508578157;

		public static ReservationRequestOption SampleReservationRequestOption00
		{
			get
			{
				return new ReservationRequestOption()
				{
					ReservationRequestOptionId = SampleReservationRequestOptionId0100,
					ReservationRequestId = Guid.Parse("3f63ec90-0343-43e2-995a-9fdb39a05b62"),
					SuggestedPickupStart = DateTime.Now,
					SuggestedPickupEnd = DateTime.Now,
					EstimatedArrivalStart = DateTime.Now,
					EstimatedArrivalEnd = DateTime.Now,
					Score = 0,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}
		public static ReservationRequestOption SampleReservationRequestOption01
		{
			get
			{
				return new ReservationRequestOption()
				{
					ReservationRequestOptionId = SampleReservationRequestOptionId0100,
					ReservationRequestId = Guid.Parse("b8cfd433-35c6-4814-b473-3a785fcb354a"),
					SuggestedPickupStart = DateTime.Now,
					SuggestedPickupEnd = DateTime.Now,
					EstimatedArrivalStart = DateTime.Now,
					EstimatedArrivalEnd = DateTime.Now,
					Score = 0,
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
