using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Employee
    {
        public Employee()
        {
            Permission = new HashSet<Permission>();
            SalaryNavigation = new HashSet<Salary>();
            Task = new HashSet<Task>();
        }

        public int Id { get; set; }
        public int UserNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImagePath { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int Salary { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual ICollection<Permission> Permission { get; set; }
        public virtual ICollection<Salary> SalaryNavigation { get; set; }
        public virtual ICollection<Task> Task { get; set; }
    }
}
