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
    
    public partial class BusDetailsGet_Result
    {
        public long BusID { get; set; }
        public string RegistrationNumber { get; set; }
        public string RouteNo { get; set; }
        public int TotalSeatCount { get; set; }
        public int MaxPassengerAllowed { get; set; }
        public int KilometerRun { get; set; }
        public string DriverName { get; set; }
        public string DriverContactNumber { get; set; }
        public string CoDriverName { get; set; }
        public string CoDriverContactNumber { get; set; }
        public string SchoolName { get; set; }
    }
}
