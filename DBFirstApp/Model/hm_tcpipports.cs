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
    
    public partial class hm_tcpipports
    {
        public int portid { get; set; }
        public byte portprotocol { get; set; }
        public int portnumber { get; set; }
        public long portaddress1 { get; set; }
        public Nullable<long> portaddress2 { get; set; }
        public byte portconnectionsecurity { get; set; }
        public long portsslcertificateid { get; set; }
    }
}
