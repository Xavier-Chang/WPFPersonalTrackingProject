using Microsoft.EntityFrameworkCore;
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
using System.Windows.Shapes;
using WPFPersonalTracking.DB;

namespace WPFPersonalTracking
{
    /// <summary>
    /// Interaction logic for DepartmentPage.xaml
    /// </summary>
    public partial class DepartmentPage : Window
    {
        public DepartmentPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public Department department;
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtDepartment.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the department name");
            }
            else
            {
                using(PERSONALTRACKINGContext db = new PERSONALTRACKINGContext())
                {
                    if(department != null && department.Id != 0)
                    {
                        Department update = new Department();
                        update.DepartmentName = txtDepartment.Text;
                        update.Id = department.Id;
                        //db.Entry(update).State = EntityState.Modified;
                        db.Department.Update(update);
                        db.SaveChanges();
                        MessageBox.Show("Department has been updated");
                    }
                    else
                    {
                        Department dpt = new Department();
                        dpt.DepartmentName = txtDepartment.Text;
                        db.Department.Add(dpt);
                        db.SaveChanges();
                        txtDepartment.Clear();
                        MessageBox.Show("Department has been added");
                    }                                      
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(department != null && department.Id !=0)
            {
                txtDepartment.Text = department.DepartmentName;
            }
        }
    }
}
