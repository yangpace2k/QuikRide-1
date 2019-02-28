// <auto-generated> - Template:XamSample, Version:1.1, Id:9131a0a2-7ceb-4f4c-b8a9-6740ac19f66c
using System;
using CGH.QuikRide.DTO.QR;

namespace CGH.QuikRide.DTO.QR
{
	public static class DemoRidePosition
	{
		public static System.Guid SampleRidePositionId0000 = Guid.Parse("b644ddfb-4a9b-4b9d-8843-f2e7faac50d8");
		public static System.Guid SampleRidePositionId0100 = Guid.Parse("155a298b-2a2c-4e00-9e1d-473e17b575b7");

		public static RidePosition SampleRidePosition00
		{
			get
			{
				return new RidePosition()
				{
					RidePositionId = SampleRidePositionId0100,
					RideId = Guid.Parse("f42c41b2-2844-443b-b58e-c1f6b3b0d798"),
					Latitude = 0,
					Longitude = 0,
					Ts = DateTime.Now,
					DataVersion = 0,
					CreatedUtcDate = DateTime.Now,
					CreatedBy = "SampleCreatedBy",
					ModifiedUtcDate = DateTime.Now,
					ModifiedBy = "SampleModifiedBy",
					IsDeleted = false,
				};
			}
		}
		public static RidePosition SampleRidePosition01
		{
			get
			{
				return new RidePosition()
				{
					RidePositionId = SampleRidePositionId0100,
					RideId = Guid.Parse("df2c32c7-a972-41f1-852a-07a890d475a3"),
					Latitude = 0,
					Longitude = 0,
					Ts = DateTime.Now,
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
