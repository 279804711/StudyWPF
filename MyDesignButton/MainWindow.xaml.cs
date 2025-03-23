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

namespace MyDesignButton
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            int num1 = 100;
            int num2 = 100;
            int total = num1 + num2;
            text1.Text = total.ToString();
            text1.Visibility = Visibility.Visible;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            text1.Text = "鼠标移入";
            text1.Visibility = Visibility.Visible;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            text1.Text = "鼠标移出";
            text1.Visibility = Visibility.Visible;
        }
    }
}
