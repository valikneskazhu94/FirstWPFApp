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

namespace FirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void paste_click(object sender, RoutedEventArgs e)
        {
            textBox1.Paste();
        }

        private void copy_click(object sender, RoutedEventArgs e)
        {
            textBox1.Copy();
        }

        private void cut_click(object sender, RoutedEventArgs e)
        {
            textBox1.Cut();
        }

        private void btn_1_click(object sender, RoutedEventArgs e)
        {
            textBox2.Background = Brushes.Aqua;
        }

        private void btn_2_click(object sender, RoutedEventArgs e)
        {
          textBox2.Background = Brushes.Black;
        }

        private void btn_3_click(object sender, RoutedEventArgs e)
        {
            textBox2.Background = Brushes.Brown;
        }

        private void Move_mouse(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            btn_4.Margin = new Thickness(rand.Next(0, 150), rand.Next(0, 150), 0, 0);

            
        }
    }
}
