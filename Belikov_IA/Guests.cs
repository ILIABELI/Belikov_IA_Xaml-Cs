//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Belikov_IA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guests()
        {
            this.payDay = new HashSet<payDay>();
            this.Reservation = new HashSet<Reservation>();
            this.room_acces = new HashSet<room_acces>();
        }
    
        public int id { get; set; }
        public string Scndname { get; set; }
        public string Frstname { get; set; }
        public string email { get; set; }
        public Nullable<int> phone { get; set; }
        public string document_number { get; set; }
        public Nullable<System.DateTime> check_in { get; set; }
        public Nullable<System.DateTime> check_out { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<payDay> payDay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<room_acces> room_acces { get; set; }
    }
}
