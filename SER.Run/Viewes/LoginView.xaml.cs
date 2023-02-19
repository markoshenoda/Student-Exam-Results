using SER.Run.ViewMoules;
using SER.Run.ViewMoules.Windows;
using System.Windows.Controls;

namespace SER.Run.Viewes
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewModule();
        }
    }
}