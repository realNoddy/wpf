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

namespace Dashboard
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private Frame MainWindowFrame;
        public RegisterPage(Frame mainWindowFrame)
        {
            InitializeComponent();
            MainWindowFrame = mainWindowFrame;
        }

        private void click_btnRegister(object sender, RoutedEventArgs e)
        {

        }
        private void click_switchToLogin(object sender, MouseButtonEventArgs e)
        {
            MainWindowFrame.Content = new LoginPage(MainWindowFrame);
        }

        private void checkBox_Check(object sender, RoutedEventArgs e)
        {
            if (checkboxAgb.IsChecked == true)
            {
                btnLogin.IsEnabled = true;
                btnLogin.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
            }
            else
            {
                btnLogin.IsEnabled = false;
                btnLogin.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7D7D7D"));
            }
        }
    }
}
