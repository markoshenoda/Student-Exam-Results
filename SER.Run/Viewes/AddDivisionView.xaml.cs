using DataBaseManger.Modules;
using SER.Run.ViewMoules;
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

namespace SER.Run.Viewes
{
    /// <summary>
    /// Interaction logic for AddDivisionView.xaml
    /// </summary>
    public partial class AddDivisionView : UserControl
    {
        public AddDivisionView()
        {
            InitializeComponent();
        }

        //private void tree_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    foreach (Division item in e.RemovedItems)
        //        ((AddEditeEducationalInstitutionsViewModul)DataContext).SelectedDivisions.Remove(item);

        //    foreach (Division item in e.AddedItems)
        //        ((AddEditeEducationalInstitutionsViewModul)DataContext).SelectedDivisions.Add(item);
        //}
    }
}
