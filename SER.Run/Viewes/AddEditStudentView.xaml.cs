using DataBaseManger.Modules;
using SER.Run.ViewMoules;
using System.Windows;
using System.Windows.Controls;

namespace SER.Run.Viewes
{
    /// <summary>
    /// Interaction logic for AddEditStudentView.xaml
    /// </summary>
    public partial class AddEditStudentView : UserControl
    {
        public AddEditStudentView()
        {
            InitializeComponent();
        }

        private void tree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (tree.SelectedItem is not null and InstitutionDivision)
                ((AddEditStudentViewModule)DataContext).SelectedInDi = tree.SelectedItem as InstitutionDivision;
        }
    }
}