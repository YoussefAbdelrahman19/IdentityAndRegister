//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GradProjectV5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Beneficier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Beneficier()
        {
            this.BeneficierMedicineRequests = new HashSet<BeneficierMedicineRequest>();
        }
    
        public int ID { get; set; }
        public Nullable<int> MemeberId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Member Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeneficierMedicineRequest> BeneficierMedicineRequests { get; set; }
    }
}