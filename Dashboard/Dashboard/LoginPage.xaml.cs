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
using Dashboard;

namespace Dashboard
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private Frame MainWindowFrame;
        public LoginPage(Frame mainWindowFrame)
        {
            InitializeComponent();
            MainWindowFrame = mainWindowFrame;
        }

        private void click_btnLogin(object sender, RoutedEventArgs e)
        {

        }

        private void click_switchToRegister(object sender, MouseButtonEventArgs e)
        {
            MainWindowFrame.Content = new RegisterPage(MainWindowFrame);
        }

    }
}
