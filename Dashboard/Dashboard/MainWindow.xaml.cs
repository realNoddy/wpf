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
        public MainWindow()
        {
            InitializeComponent();
            FrameLoginRegister.Content = new LoginPage(FrameLoginRegister);
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
