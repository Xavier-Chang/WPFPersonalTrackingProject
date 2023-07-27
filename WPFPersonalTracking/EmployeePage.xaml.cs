using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using Microsoft.Win32;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFPersonalTracking.DB;
using WPFPersonalTracking.ViewModels;
using System.Text.RegularExpressions;
using System.IO;

namespace WPFPersonalTracking
{
    /// <summary>
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Window
    {
        public EmployeePage()
        {
            InitializeComponent();
        }
        PERSONALTRACKINGContext db = new PERSONALTRACKINGContext();
        List<Position> positions = new List<Position>();
        public EmployeeDetailModel model;
        private void Window_Loaded(object sender, RoutedEventArgs e)
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
            //update condition
            if(model !=null && model.Id !=0)
            {
                cmbDepartment.SelectedValue = model.DepartmentID;
                cmbPosition.SelectedValue = model.PositionID;
                txtUserNo.Text = model.UserNo.ToString();
                txtPassword.Text = model.Password;
                txtName.Text = model.Name;
                txtSurname.Text = model.Surname;
                txtSalary.Text = model.Salary.ToString();
                txtAddress.AppendText(model.Address);
                picker1.SelectedDate = model.BirthDay;
                chisAdmin.IsChecked = model.IsAdmin;
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(@"Image/" + model.ImagePath, UriKind.RelativeOrAbsolute);
                image.EndInit();
                EmployeeImage.Source = image;

            }
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
        OpenFileDialog dialog = new OpenFileDialog();
        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            if (dialog.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(dialog.FileName);
                image.EndInit();
                EmployeeImage.Source = image;
                txtImage.Text = dialog.FileName;
            }
        }

        private void txtUserNo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(txtUserNo.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtName.Text.Trim() == "" 
                || txtSurname.Text.Trim() == "" || txtSalary.Text.Trim() == "" || cmbDepartment.SelectedIndex==-1 
                || cmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill the blanks");
            }
            else
            {
                if(model != null && model.Id != 0){
                    Employee employee = db.Employee.Find(model.Id);
                    List<Employee> employeelist = db.Employee.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text) && x.Id != model.Id).ToList();
                    if(employeelist.Count > 0)
                    {
                        MessageBox.Show("This user number is already taken");
                    }
                    else
                    {
                        if (txtImage.Text.Trim() != "")
                        {
                            if (File.Exists(@"Images//" + employee.ImagePath))
                            {
                                File.Delete(@"Images//" + employee.ImagePath);
                                string filename = "";
                                string Unique = Guid.NewGuid().ToString();
                                filename += Unique + System.IO.Path.GetFileName(txtImage.Text);
                                File.Copy(txtImage.Text, @"Images//" + filename);
                                employee.ImagePath = filename;
                            }
                        }
                        employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                        employee.Password = txtPassword.Text;
                        employee.Name = txtName.Text;
                        employee.Surname = txtSurname.Text;
                        employee.Salary = Convert.ToInt32(txtSalary.Text);
                        employee.DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
                        employee.PositionId = Convert.ToInt32(cmbPosition.SelectedValue);
                        employee.Address = new TextRange(txtAddress.Document.ContentStart, txtAddress.Document.ContentEnd).Text;
                        employee.BirthDay = picker1.SelectedDate;
                        employee.IsAdmin = (bool)chisAdmin.IsChecked;
                        db.SaveChanges();
                        MessageBox.Show("Employee has been updated");
                    }                   
                }
                else
                {
                    var Uniquelist = db.Employee.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
                    if (Uniquelist.Count > 0)
                    {
                        MessageBox.Show("This user number is already taken");
                    }
                    else
                    {

                        Employee employee = new Employee();
                        employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                        employee.Password = txtPassword.Text;
                        employee.Name = txtName.Text;
                        employee.Surname = txtSurname.Text;
                        employee.Salary = Convert.ToInt32(txtSalary.Text);
                        employee.DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
                        employee.PositionId = Convert.ToInt32(cmbPosition.SelectedValue);
                        TextRange text = new TextRange(txtAddress.Document.ContentStart, txtAddress.Document.ContentEnd);
                        employee.Address = text.Text;
                        employee.BirthDay = picker1.SelectedDate;
                        employee.IsAdmin = (bool)chisAdmin.IsChecked;
                        string filename = "";
                        string Unique = Guid.NewGuid().ToString();
                        filename += Unique + dialog.SafeFileName;
                        employee.ImagePath = filename;
                        db.Employee.Add(employee);
                        db.SaveChanges();
                        File.Copy(txtImage.Text, @"Images//" + filename);
                        MessageBox.Show("Employee has been added");
                        txtUserNo.Clear();
                        txtPassword.Clear();
                        txtName.Clear();
                        txtSurname.Clear();
                        txtSalary.Clear();
                        txtAddress.Document.Blocks.Clear();
                        cmbDepartment.SelectedIndex = -1;
                        cmbPosition.SelectedIndex = -1;
                        picker1.SelectedDate = DateTime.Today;
                        chisAdmin.IsChecked = false;
                        EmployeeImage.Source = new BitmapImage();
                        txtImage.Clear();
                    }
                }
                
            }
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            
            var Uniquelist = db.Employee.Where(x => x.UserNo == Convert.ToInt32(txtUserNo.Text)).ToList();
            if (Uniquelist.Count > 0)
            {
                MessageBox.Show("This user number is already taken");
            }
            else
            {
                MessageBox.Show("This user number is available");
                
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
