using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Permissionstate
    {
        public Permissionstate()
        {
            Permission = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public string Statename { get; set; }

        public virtual ICollection<Permission> Permission { get; set; }
    }
}
