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
    
    public partial class Tbl_Checks
    {
        public int CheckID { get; set; }
        public System.DateTime CheckDate { get; set; }
        public int OperatorID { get; set; }
        public int CustomerID { get; set; }
        public int NumberID { get; set; }
        public double CheckSum { get; set; }
    
        public virtual Tbl_Customers Tbl_Customers { get; set; }
        public virtual Tbl_Numbers Tbl_Numbers { get; set; }
        public virtual Tbl_Operators Tbl_Operators { get; set; }
    }
}