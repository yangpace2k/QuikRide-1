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

    // VehicleFeatureType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class VehicleFeatureTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VehicleFeatureType>
    {
        public VehicleFeatureTypeConfiguration()
            : this("dbo")
        {
        }

        public VehicleFeatureTypeConfiguration(string schema)
        {
            ToTable("VehicleFeatureType", schema);
            HasKey(x => x.VehicleFeatureTypeId);

            Property(x => x.VehicleFeatureTypeId).HasColumnName(@"VehicleFeatureTypeId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LanguageTypeId).HasColumnName(@"LanguageTypeId").HasColumnType("int").IsRequired();
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DisplayText).HasColumnName(@"DisplayText").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.DisplayPriority).HasColumnName(@"DisplayPriority").HasColumnType("int").IsRequired();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(1024);
            Property(x => x.DataVersion).HasColumnName(@"DataVersion").HasColumnType("int").IsRequired();
            Property(x => x.CreatedUtcDate).HasColumnName(@"CreatedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ModifiedUtcDate).HasColumnName(@"ModifiedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasRequired(a => a.LanguageType).WithMany(b => b.VehicleFeatureTypes).HasForeignKey(c => c.LanguageTypeId).WillCascadeOnDelete(false); // FK_VehicleFeatureType_LanguageType
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
