//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDbFirst.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FOOTBALLCLUB
    {
        public int FOOTBALLCLUBID { get; set; }
        public string FOOTBALLCLUBNAME { get; set; }
        public Nullable<int> COUNTRYID { get; set; }
    
        public virtual COUNTRY COUNTRY { get; set; }
    }
}
