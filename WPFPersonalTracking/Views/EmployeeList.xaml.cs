using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFPersonalTracking.DB;
using WPFPersonalTracking.ViewModels;

namespace WPFPersonalTracking.Views
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : UserControl
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            EmployeePage page = new EmployeePage();
            page.ShowDialog();
            FillDatagrid();
        }

        PERSONALTRACKINGContext db = new PERSONALTRACKINGContext();
        List<Position> positions = new List<Position>();
        List<EmployeeDetailModel> list = new List<EmployeeDetailModel>();
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            FillDatagrid();
        }

        private void cmbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
            if (cmbDepartment.SelectedIndex != -1)
            {
                cmbPosition.ItemsSource = positions.Where(x => x.DepartmentId == DepartmentId).ToList();
                cmbPosition.DisplayMemberPath = "PositionName";
                cmbPosition.SelectedValuePath = "Id";
                cmbPosition.SelectedIndex = -1;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //implement search function
            List<EmployeeDetailModel> searchList = list;
            
            string surname = txtSurname.Text.Trim().ToLower();
            string name = txtName.Text.Trim().ToLower();
            if (txtUserNo.Text.Trim() != "")
                searchList = searchList.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
            if (txtName.Text.Trim() != "")
                searchList = searchList.Where(x => x.Name.ToLower().Contains(txtName.Text)).ToList();
            if (surname != "")
                searchList = searchList.Where(x => x.Surname.ToLower().Contains(surname)).ToList();
            if (cmbPosition.SelectedIndex != -1)
                searchList = searchList.Where(x => x.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            if (cmbDepartment.SelectedIndex != -1)
                searchList = searchList.Where(x => x.DepartmentID == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            gridEmployee.ItemsSource = searchList;

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtUserNo.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            gridEmployee.ItemsSource = list;
        }

        void FillDatagrid()
        {
            cmbDepartment.ItemsSource = db.Department.ToList();
            cmbDepartment.DisplayMemberPath = "DepartmentName";
            cmbDepartment.SelectedValuePath = "Id";
            cmbDepartment.SelectedIndex = -1;
            positions = db.Position.ToList();
            cmbPosition.ItemsSource = positions;
            cmbPosition.DisplayMemberPath = "PositionName";
            cmbPosition.SelectedValuePath = "Id";
            cmbPosition.SelectedIndex = -1;
            list = db.Employee.Include(x => x.Position).Include(x => x.Department).Select(x => new EmployeeDetailModel
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                BirthDay = (DateTime)x.BirthDay,
                DepartmentID = x.DepartmentId,
                DepartmentName = x.Department.DepartmentName,
                IsAdmin = (bool)x.IsAdmin,
                Password = x.Password,
                PositionID = x.PositionId,
                PositionName = x.Position.PositionName,
                Salary = x.Salary,
                Surname = x.Surname,
                UserNo = x.UserNo,
                ImagePath = x.ImagePath
            }).OrderBy(x => x.UserNo).ToList();
            gridEmployee.ItemsSource = list;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDetailModel model = (EmployeeDetailModel)gridEmployee.SelectedItem;
            EmployeePage page = new EmployeePage();
            page.model = model;
            page.ShowDialog();
            FillDatagrid();
        }
    }
}
