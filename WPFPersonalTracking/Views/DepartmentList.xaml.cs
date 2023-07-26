using System;
using System.Collections.Generic;
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

namespace WPFPersonalTracking.Views
{
    /// <summary>
    /// Interaction logic for DepartmentList.xaml
    /// </summary>
    public partial class DepartmentList : UserControl
    {
        public DepartmentList()
        {
            InitializeComponent();
            using (PERSONALTRACKINGContext db = new PERSONALTRACKINGContext())
            {
                List<Department> list = db.Department.OrderBy(x => x.DepartmentName).ToList();
                gridDepartment.ItemsSource = list;
            }
           
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DepartmentPage page = new DepartmentPage();
            page.ShowDialog();
            using (PERSONALTRACKINGContext db = new PERSONALTRACKINGContext())
            {
                List<Department> list = db.Department.OrderBy(x => x.DepartmentName).ToList();
                gridDepartment.ItemsSource = list;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //i want to update the selected department
            if (gridDepartment.SelectedItem == null)
            {
                MessageBox.Show("Please select a department");
            }
            else
            {
                Department dpt = (Department)gridDepartment.SelectedItem;
                DepartmentPage page = new DepartmentPage();
                page.department = dpt;
                page.ShowDialog();
                using (PERSONALTRACKINGContext db = new PERSONALTRACKINGContext())
                {
                    gridDepartment.ItemsSource = db.Department.OrderBy(x => x.DepartmentName).ToList();
                    
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
             if (gridDepartment.SelectedItem == null)
            {
                MessageBox.Show("Please select a department");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Are you sure?", "Question", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Department dpt = (Department)gridDepartment.SelectedItem;
                    using (PERSONALTRACKINGContext db = new PERSONALTRACKINGContext())
                    {
                        db.Department.Remove(dpt);
                        db.SaveChanges();
                        MessageBox.Show("Department has been deleted");
                        gridDepartment.ItemsSource = db.Department.OrderBy(x => x.DepartmentName).ToList();
                    }
                }
            }
        }
    }
}
