using System;
using System.Collections.Generic;
using System.Text;

namespace WPFPersonalTracking.ViewModels
{
    public class EmployeeDetailModel
    {
        public int Id { get; set; }
        public int UserNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public int Salary { get; set; }
        public DateTime BirthDay { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
