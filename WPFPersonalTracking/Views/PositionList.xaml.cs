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
    /// Interaction logic for PositionList.xaml
    /// </summary>
    public partial class PositionList : UserControl
    {
        public PositionList()
        {
            InitializeComponent();
        }
        PERSONALTRACKINGContext db = new PERSONALTRACKINGContext();

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            FillGrid();
        }
        void FillGrid()
        {
            var list = db.Position.Include(x => x.Department).Select(a => new
            {
                PositionId = a.Id,
                PositionName = a.PositionName,
                departmentName = a.Department.DepartmentName,
                departmentId = a.DepartmentId
            }).OrderBy(x => x.PositionName).ToList();

            List<PositionModel> modellist = new List<PositionModel>();
            foreach (var item in list)
            {
                PositionModel model = new PositionModel();
                model.Id = item.PositionId;
                model.PositionName = item.PositionName;
                model.DepartmentId = item.departmentId;
                model.DepartmentName = item.departmentName;
                modellist.Add(model);
            }
            gridPosition.ItemsSource = modellist;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            PositionPage page = new PositionPage();
            page.ShowDialog();
            FillGrid();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //update the selected position
            if (gridPosition.SelectedItem == null)
            {
                MessageBox.Show("Please select a position");
            }
            else
            {
                PositionModel model = (PositionModel)gridPosition.SelectedItem;
                if (model !=null && model.Id != 0)
                {
                    PositionPage page = new PositionPage();
                    page.model = model;
                    page.ShowDialog();
                    FillGrid();
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (gridPosition.SelectedItem == null)
            {
                MessageBox.Show("Please select a position");
            }
            else
            {
                PositionModel model = (PositionModel)gridPosition.SelectedItem;
                if (model != null && model.Id != 0)
                {
                    var result = MessageBox.Show("Are you sure?", "Question", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        var position = db.Position.FirstOrDefault(x => x.Id == model.Id);
                        db.Position.Remove(position);
                        db.SaveChanges();
                        MessageBox.Show("Department has been deleted");
                        FillGrid();
                    }
                }
            }
        }
    }
}
