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
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Cleaning_Room = new HashSet<Cleaning_Room>();
        }
    
        public int id { get; set; }
        public string Frstname { get; set; }
        public string Scndname { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public Nullable<bool> Try_Plugin { get; set; }
        public Nullable<bool> is_blocked { get; set; }
        public Nullable<bool> is_First { get; set; }
        public Nullable<System.DateTime> last_login { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cleaning_Room> Cleaning_Room { get; set; }
    }
}
