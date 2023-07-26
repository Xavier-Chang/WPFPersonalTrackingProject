using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Amount { get; set; }
        public int Year { get; set; }
        public int MonthId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Months Month { get; set; }
    }
}
