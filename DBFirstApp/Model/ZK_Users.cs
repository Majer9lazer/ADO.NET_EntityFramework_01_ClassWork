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
    
    public partial class ZK_Users
    {
        public int userId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string phoneNo { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<int> gender { get; set; }
        public Nullable<int> userRoleId { get; set; }
    }
}