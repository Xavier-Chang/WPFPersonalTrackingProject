using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
            Position = new HashSet<Position>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Position> Position { get; set; }
    }
}
