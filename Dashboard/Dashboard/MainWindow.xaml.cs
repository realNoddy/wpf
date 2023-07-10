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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public LoginPage _loginPage;
        public RegisterPage _registerPage;
        public MainWindow()
        {
            InitializeComponent();
            _loginPage = new LoginPage(FrameLoginRegister);
            _registerPage = new RegisterPage(FrameLoginRegister);

            _loginPage.SetSwitchPage(_registerPage);
            _registerPage.SetSwitchPage(_loginPage);

            FrameLoginRegister.Content = _loginPage;
        }

        private void click_Exit(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void click_DragWindow(object sender, MouseButtonEventArgs e)
        {
             DragMove();
        }

        private void mouseEnter_Exit(object sender, MouseEventArgs e)
        {
            btnExit.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
        private void mouseLeave_Exit(object sender, MouseEventArgs e)
        {
            btnExit.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#99FFFFFF"));
        }
    }
}
