// <auto-generated> - Template:DTO, Version:1.1, Id:58fa7ee2-89f7-41e6-85ed-8d4482653990
namespace CGH.QuikRide.DTO.QR
{
	public partial class NotificationType
	{
		public NotificationType()
		{
			InitializePartial();
		}

		public int NotificationTypeId { get; set; } // Primary key
		public int LanguageTypeId { get; set; }
		public string Code { get; set; }
		public string DisplayText { get; set; }
		public int DisplayPriority { get; set; }
		public string Description { get; set; }
		public int DataVersion { get; set; }
		public System.DateTime CreatedUtcDate { get; set; }
		public string CreatedBy { get; set; }
		public System.DateTime ModifiedUtcDate { get; set; }
		public string ModifiedBy { get; set; }
		public bool IsDeleted { get; set; }
		public virtual System.Collections.Generic.ICollection<UsersNotificationType> UsersNotificationTypes { get; set; } // Many to many mapping
		public virtual LanguageType LanguageType { get; set; } 


		partial void InitializePartial();

	}
}
