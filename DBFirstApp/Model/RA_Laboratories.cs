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
    
    public partial class RA_Laboratories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RA_Laboratories()
        {
            this.RA_Tests = new HashSet<RA_Tests>();
        }
    
        public int id { get; set; }
        public string city { get; set; }
        public string laboratoryName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RA_Tests> RA_Tests { get; set; }
    }
}