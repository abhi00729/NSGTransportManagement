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
    
    public partial class CoreBusRouteSchool
    {
        public long BusRouteSchoolID { get; set; }
        public long BusRouteID { get; set; }
        public long SchoolID { get; set; }
        public int EntryUserID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual CoreBusRoute CoreBusRoute { get; set; }
        public virtual CoreUser CoreUser { get; set; }
        public virtual CoreSchool CoreSchool { get; set; }
        public virtual CoreUser CoreUser1 { get; set; }
    }
}