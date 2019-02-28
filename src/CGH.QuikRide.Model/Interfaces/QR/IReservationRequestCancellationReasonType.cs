// <auto-generated> - Template:ModelsBackedByDtoInterface, Version:1.1, Id:4d03f2c7-de27-4aae-a267-cad747c9606a
using System;
using System.Collections.Generic;

namespace CGH.QuikRide.Model.QR.Interface
{
	public partial interface IReservationRequestCancellationReasonType
	{
		string Code { get; }
		string CreatedBy { get; }
		System.DateTime CreatedUtcDate { get; }
		int DataVersion { get; }
		string Description { get; }
		int DisplayPriority { get; }
		string DisplayText { get; }
		bool IsDeleted { get; }
		int LanguageTypeId { get; }
		string ModifiedBy { get; }
		System.DateTime ModifiedUtcDate { get; }
		int ReservationRequestCancellationReasonTypeId { get; }

		ILanguageType LanguageType { get; }
		List<IReservationRequest> ReservationRequests { get; }


	}
}
