//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NSGTransportManagement.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class NSGStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NSGStudent()
        {
            this.NSGStudentDocuments = new HashSet<NSGStudentDocument>();
        }
    
        public long NSGStudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Class { get; set; }
        public long SchoolID { get; set; }
        public long BusRouteID { get; set; }
        public long BusRouteDetailID { get; set; }
        public string GuardianName { get; set; }
        public string MobileNo { get; set; }
        public int RelationshipID { get; set; }
        public string NSGEmployeeCode { get; set; }
        public Nullable<int> RankID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<int> QuarterTypeID { get; set; }
        public Nullable<int> QuarterNumber { get; set; }
        public System.DateTime IssueDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public byte[] PassHolderPhoto { get; set; }
        public int EntryUserID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual CoreBusRoute CoreBusRoute { get; set; }
        public virtual CoreBusRouteDetail CoreBusRouteDetail { get; set; }
        public virtual CoreQuarterType CoreQuarterType { get; set; }
        public virtual CoreRank CoreRank { get; set; }
        public virtual CoreRelationship CoreRelationship { get; set; }
        public virtual CoreSchool CoreSchool { get; set; }
        public virtual CoreUnit CoreUnit { get; set; }
        public virtual CoreUser CoreUser { get; set; }
        public virtual CoreUser CoreUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NSGStudentDocument> NSGStudentDocuments { get; set; }
    }
}
