//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend_DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Income
    {
        public int IncomeId { get; set; }
        public int Client { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime IncomeDate { get; set; }
        public string Desc { get; set; }
    
        public virtual Client Client1 { get; set; }
    }
}
