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
    
    public partial class PassHolderDetailsGet_Result
    {
        public long NSGStudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GuardianName { get; set; }
        public string Class { get; set; }
        public string SchoolName { get; set; }
        public string RouteNo { get; set; }
        public string BusStopName { get; set; }
        public System.DateTime IssueDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string IsActive { get; set; }
        public string EntryBy { get; set; }
    }
}
