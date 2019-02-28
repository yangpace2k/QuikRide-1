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

    // FeedbackType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class FeedbackType
    {
        public int FeedbackTypeId { get; set; } // FeedbackTypeId (Primary key)
        public int LanguageTypeId { get; set; } // LanguageTypeId
        public string Code { get; set; } // Code (length: 50)
        public string DisplayText { get; set; } // DisplayText (length: 128)
        public int DisplayPriority { get; set; } // DisplayPriority
        public string Description { get; set; } // Description (length: 1024)
        public int DataVersion { get; set; } // DataVersion
        public System.DateTime CreatedUtcDate { get; set; } // CreatedUtcDate
        public string CreatedBy { get; set; } // CreatedBy (length: 200)
        public System.DateTime ModifiedUtcDate { get; set; } // ModifiedUtcDate
        public string ModifiedBy { get; set; } // ModifiedBy (length: 200)
        public bool IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child Feedbacks where [Feedback].[FeedbackTypeId] point to this entity (FK_Feedback_FeedbackType)
        /// </summary>
        public System.Collections.Generic.ICollection<Feedback> Feedbacks { get; set; } // Feedback.FK_Feedback_FeedbackType

        // Foreign keys

        /// <summary>
        /// Parent LanguageType pointed by [FeedbackType].([LanguageTypeId]) (FK_FeedbackType_LanguageType)
        /// </summary>
        public LanguageType LanguageType { get; set; } // FK_FeedbackType_LanguageType

        public FeedbackType()
        {
            DisplayPriority = 100;
            DataVersion = 1;
            CreatedUtcDate = System.DateTime.UtcNow;
            ModifiedUtcDate = System.DateTime.UtcNow;
            IsDeleted = false;
            Feedbacks = new System.Collections.Generic.List<Feedback>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
