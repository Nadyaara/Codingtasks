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

namespace Игра
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i;
        public MainWindow()
        {
            i = 0;
            InitializeComponent();

        }

        private void tap_me_2_Click(object sender, RoutedEventArgs e)
        {
            null1.Content = 0;
        }

        private void button1_click(object sender, RoutedEventArgs e)
        {
            i++;
            null1.Content = i;
        }
    }


}

