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
    
    public partial class CoreBusRouteDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoreBusRouteDetail()
        {
            this.NSGStudents = new HashSet<NSGStudent>();
        }
    
        public long BusRouteDetailID { get; set; }
        public long BusRouteID { get; set; }
        public int BusStopNumber { get; set; }
        public string BusStopName { get; set; }
        public string PickUpTime { get; set; }
        public string DropTime { get; set; }
        public int EntryUserID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual CoreBusRoute CoreBusRoute { get; set; }
        public virtual CoreUser CoreUser { get; set; }
        public virtual CoreUser CoreUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NSGStudent> NSGStudents { get; set; }
    }
}
