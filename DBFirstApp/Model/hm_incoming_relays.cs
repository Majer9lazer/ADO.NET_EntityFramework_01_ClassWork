//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class hm_incoming_relays
    {
        public int relayid { get; set; }
        public string relayname { get; set; }
        public long relaylowerip1 { get; set; }
        public Nullable<long> relaylowerip2 { get; set; }
        public long relayupperip1 { get; set; }
        public Nullable<long> relayupperip2 { get; set; }
    }
}
