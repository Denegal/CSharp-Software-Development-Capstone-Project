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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Finances = new HashSet<Finance>();
        }
    
        public int ClientId { get; set; }
        public string FName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Waiver { get; set; }
        public string Injuries { get; set; }
        public int Pregnant { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyContactPhone { get; set; }
        public int MedicalCare { get; set; }
        public string MedicalHistory { get; set; }
        public string LName { get; set; }
        public int ClassCredit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Finance> Finances { get; set; }
    }
}
