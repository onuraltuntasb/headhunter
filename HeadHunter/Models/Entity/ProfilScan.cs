//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeadHunter.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfilScan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProfilScan()
        {
            this.ProfileMeta = new HashSet<ProfileMeta>();
            this.ProfileScore = new HashSet<ProfileScore>();
        }
    
        public int ProfilScanId { get; set; }
        public Nullable<System.DateTime> ProfilScanDate { get; set; }
        public Nullable<bool> ProfilScanFlag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileMeta> ProfileMeta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileScore> ProfileScore { get; set; }
    }
}