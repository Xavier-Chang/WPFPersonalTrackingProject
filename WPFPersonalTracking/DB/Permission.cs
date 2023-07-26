using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Permission
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime PermissionStartDate { get; set; }
        public DateTime PermissionEndDate { get; set; }
        public int PermissionState { get; set; }
        public string PermissionExplanation { get; set; }
        public string PermissionDay { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Permissionstate PermissionStateNavigation { get; set; }
    }
}
