using System.Windows;
using System.Windows.Controls;
using SER.Run.ViewMoules;
using SER.Run.ViewMoules.Windows;

namespace SER.Run
{
    /// <summary>
    /// Interaction logic for StarupWindows.xaml
    /// </summary>
    public partial class StarupWindows : Window
    {
        public StarupWindows()
        {
            InitializeComponent();
            DataContext = new StartupWindows(this); 
        }
    }
}