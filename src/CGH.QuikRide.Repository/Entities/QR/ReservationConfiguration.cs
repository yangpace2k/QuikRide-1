// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace CGH.QuikRide.Repository.Entities.QR
{

    // Reservation
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class ReservationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Reservation>
    {
        public ReservationConfiguration()
            : this("dbo")
        {
        }

        public ReservationConfiguration(string schema)
        {
            ToTable("Reservation", schema);
            HasKey(x => x.ReservationId);

            Property(x => x.ReservationId).HasColumnName(@"ReservationId").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("int").IsRequired();
            Property(x => x.PickUpLocationId).HasColumnName(@"PickUpLocationId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.DestinationLocationId).HasColumnName(@"DestinationLocationId").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ReservationRequestOptionId).HasColumnName(@"ReservationRequestOptionId").HasColumnType("int").IsRequired();
            Property(x => x.ReservationStatusTypeId).HasColumnName(@"ReservationStatusTypeId").HasColumnType("int").IsRequired();
            Property(x => x.ReservationCancellationReasonId).HasColumnName(@"ReservationCancellationReasonId").HasColumnType("int").IsOptional();
            Property(x => x.NumberOfAdults).HasColumnName(@"NumberOfAdults").HasColumnType("int").IsRequired();
            Property(x => x.NumberOfChildren).HasColumnName(@"NumberOfChildren").HasColumnType("int").IsRequired();
            Property(x => x.NumberOfBabies).HasColumnName(@"NumberOfBabies").HasColumnType("int").IsRequired();
            Property(x => x.NumberOfWheelchairs).HasColumnName(@"NumberOfWheelchairs").HasColumnType("int").IsRequired();
            Property(x => x.NumberOfBikes).HasColumnName(@"NumberOfBikes").HasColumnType("int").IsRequired();
            Property(x => x.PersonalCareAttendantIncluded).HasColumnName(@"PersonalCareAttendantIncluded").HasColumnType("bit").IsRequired();
            Property(x => x.DataVersion).HasColumnName(@"DataVersion").HasColumnType("int").IsRequired();
            Property(x => x.CreatedUtcDate).HasColumnName(@"CreatedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ModifiedUtcDate).HasColumnName(@"ModifiedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.ReservationCancellationReasonType).WithMany(b => b.Reservations).HasForeignKey(c => c.ReservationCancellationReasonId).WillCascadeOnDelete(false); // FK_Reservation_ReservationCancellationReasonType
            HasRequired(a => a.Location).WithMany(b => b.Reservations).HasForeignKey(c => c.PickUpLocationId).WillCascadeOnDelete(false); // FK_Reservation_Location
            HasRequired(a => a.ReservationRequestOption).WithMany(b => b.Reservations).HasForeignKey(c => c.ReservationRequestOptionId).WillCascadeOnDelete(false); // FK_Reservation_ReservationRequestOption
            HasRequired(a => a.User).WithMany(b => b.Reservations).HasForeignKey(c => c.UserId).WillCascadeOnDelete(false); // FK_Reservation_Users
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
