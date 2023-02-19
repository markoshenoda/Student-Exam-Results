using SER.Run.ViewMoules;
using System.Windows;
using System.Windows.Controls;

namespace SER.Run.UI_Elements
{
    /// <summary>
    /// Interaction logic for ListItemsWithDots.xaml
    /// </summary>
    public partial class ListItemsWithDots : UserControl
    {
        public ViewModuleBase TargetObject
        {
            get { return (ViewModuleBase)GetValue(TargetObjectProperty); }
            set { SetValue(TargetObjectProperty, value); }
        }

        public static readonly DependencyProperty TargetObjectProperty =
            DependencyProperty.Register("TargetObject", typeof(object), typeof(ListItemsWithDots), new PropertyMetadata(null));


        public ListItemsWithDots()
        {
            InitializeComponent();
            DataContext = TargetObject;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dropbutton.IsOpen = false;
        }
    }
}
