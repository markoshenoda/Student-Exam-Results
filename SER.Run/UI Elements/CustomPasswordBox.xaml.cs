using MahApps.Metro.IconPacks;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace SER.Run.UI_Elements
{
    /// <summary>
    /// Interaction logic for CustomPasswordBox.xaml
    /// </summary>
    public partial class CustomPasswordBox : UserControl
    {
        private bool _isPasswordChanging;

        public bool ShowPassword
        {
            get { return (bool)GetValue(HidePassword); }
            set { SetValue(HidePassword, value); }
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(CustomPasswordBox),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    PasswordPropertyChanged, null, false, UpdateSourceTrigger.PropertyChanged));

        public static readonly DependencyProperty HidePassword =
            DependencyProperty.Register("ShowPassword", typeof(bool), typeof(CustomPasswordBox),
                new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    HidePasswordPropartyChanged, null, false, UpdateSourceTrigger.PropertyChanged));

        private static void HidePasswordPropartyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CustomPasswordBox passwordBox)
            {
                passwordBox.UpdateState();
            }
        }

        private void UpdateState()
        {
            if (ShowPassword)
            {
                textBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Collapsed;
                textBox.Focus();
                return;
            }
            textBox.Visibility = Visibility.Collapsed;
            passwordBox.Visibility = Visibility.Visible;
            passwordBox.Focus();
        }

        private static void PasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CustomPasswordBox passwordBox)
            {
                passwordBox.UpdatePassword();
            }
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); passwordBox.Password = Password;textBox.Text = Password; }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _isPasswordChanging = true;
            Password = passwordBox.Password;
            _isPasswordChanging = false;
        }

        private void UpdatePassword()
        {
            if (_isPasswordChanging)
            {
                passwordBox.Password = Password;
                textBox.Text = Password;
            }
        }

        public CustomPasswordBox()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _isPasswordChanging = true;
            Password = textBox.Text;
            _isPasswordChanging = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button x = (Button)sender;
            PackIconBootstrapIcons y = (PackIconBootstrapIcons)x.Template.FindName("ico", (FrameworkElement)sender);

            ShowPassword = !ShowPassword;

            if (!ShowPassword)
            {
                y.Kind = PackIconBootstrapIconsKind.EyeFill;
            }
            else
            {
                y.Kind = PackIconBootstrapIconsKind.EyeSlashFill;
            }
        }

        private void UserControl_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ShowPassword)
            {
                passwordBox.Focus();
                return;
            }
            textBox.Focus();
        }

        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!ShowPassword)
            {
                passwordBox.Focus();
                return;
            }
            textBox.Focus();
        }
    }
}