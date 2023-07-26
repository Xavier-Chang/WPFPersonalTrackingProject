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
using WPFPersonalTracking.ViewModels;

namespace WPFPersonalTracking
{
    /// <summary>
    /// Interaction logic for PositionPage.xaml
    /// </summary>
    public partial class PositionPage : Window
    {
        public PositionPage()
        {
            InitializeComponent();
        }

        PERSONALTRACKINGContext db = new PERSONALTRACKINGContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           var list = db.Department.ToList().OrderBy(x => x.DepartmentName);
            cmbDepartment.ItemsSource = list;
            cmbDepartment.DisplayMemberPath = "DepartmentName";
            cmbDepartment.SelectedValuePath = "Id";
            cmbDepartment.SelectedIndex = -1;
            if(model != null && model.Id !=0)
            {
                cmbDepartment.SelectedValue = model.DepartmentId;
                txtPosition.Text = model.PositionName;               
            }
           
        }

        public PositionModel model;

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(cmbDepartment.SelectedIndex == -1 || txtPosition.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the blanks");
            }
            else
            {
                if (db.Position.Any(x => x.PositionName == txtPosition.Text))
                {
                    MessageBox.Show("This position already exists");
                }
                else
                {
                    if (model != null && model.Id != 0)
                    {
                        Position pst = new Position();
                        pst.DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
                        pst.PositionName = txtPosition.Text;
                        pst.Id = model.Id;
                        db.Position.Update(pst);
                        db.SaveChanges();
                        MessageBox.Show("Position has been updated");
                    }
                    else
                    {
                        Position position = new Position();
                        position.PositionName = txtPosition.Text;
                        position.DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
                        db.Position.Add(position);
                        db.SaveChanges();
                        cmbDepartment.SelectedIndex = -1;
                        txtPosition.Clear();
                        MessageBox.Show("Position has been added");
                    }
                }
            }
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
