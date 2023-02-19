using DataBaseManger.Modules;
using SER.Run.ViewMoules;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SER.Run.Viewes
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddEditUserView : UserControl
    {
        public AddEditUserView()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ((AddEditUserViewModule)DataContext).SelectedEducationalInstitution.Add((InstitutionDivision)tree.SelectedItem);
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ((AddEditUserViewModule)DataContext).SelectedEducationalInstitution.Remove((InstitutionDivision)tree.SelectedItem);
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (tree.SelectedItem is not null and InstitutionDivision)
            {
                CheckBox check = (CheckBox)((StackPanel)sender).Children[0];
                check.IsChecked = !check.IsChecked;
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ((AddEditUserViewModule)DataContext).Password = p.Password;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            p.Password = ((AddEditUserViewModule)DataContext).Password;
        }
    }
}