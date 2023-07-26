using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Taskstate
    {
        public Taskstate()
        {
            Task = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<Task> Task { get; set; }
    }
}
