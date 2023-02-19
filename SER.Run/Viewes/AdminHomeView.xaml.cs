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
    /// Interaction logic for AdminHomePage.xaml
    /// </summary>
    public partial class AdminHomeView : UserControl
    {
        public AdminHomeView()
        {
            InitializeComponent();
            DataContext = new AdminHomeViewModule();
            tree.SelectedIndex = 0;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((AdminHomeViewModule)DataContext).SelectedViews = (SelectedView)tree.SelectedIndex;
        }
    }
}
