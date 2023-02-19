using DataBaseManger.Modules;
using SER.Run.ViewMoules;
using System.Windows.Controls;

namespace SER.Run.Viewes
{
    /// <summary>
    /// Interaction logic for AddEditSubjects.xaml
    /// </summary>
    public partial class AddEditSubjectsView : UserControl
    {
        public AddEditSubjectsView()
        {
            InitializeComponent();
        }

        private void tree_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Division item in e.RemovedItems)
                ((AddEditSubjectsViewModule)DataContext).SelectedDivisions.Remove(item);

            foreach (Division item in e.AddedItems)
                ((AddEditSubjectsViewModule)DataContext).SelectedDivisions.Add(item);
        }
    }
}