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
    
    public partial class hm_domains
    {
        public int domainid { get; set; }
        public string domainname { get; set; }
        public byte domainactive { get; set; }
        public string domainpostmaster { get; set; }
        public int domainmaxsize { get; set; }
        public string domainaddomain { get; set; }
        public int domainmaxmessagesize { get; set; }
        public byte domainuseplusaddressing { get; set; }
        public string domainplusaddressingchar { get; set; }
        public int domainantispamoptions { get; set; }
        public byte domainenablesignature { get; set; }
        public byte domainsignaturemethod { get; set; }
        public string domainsignatureplaintext { get; set; }
        public string domainsignaturehtml { get; set; }
        public byte domainaddsignaturestoreplies { get; set; }
        public byte domainaddsignaturestolocalemail { get; set; }
        public int domainmaxnoofaccounts { get; set; }
        public int domainmaxnoofaliases { get; set; }
        public int domainmaxnoofdistributionlists { get; set; }
        public int domainlimitationsenabled { get; set; }
        public int domainmaxaccountsize { get; set; }
        public string domaindkimselector { get; set; }
        public string domaindkimprivatekeyfile { get; set; }
    }
}