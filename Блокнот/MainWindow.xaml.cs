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

namespace Блокнот
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Color(object sender, RoutedEventArgs e)
        {
            TextBox.Foreground = Foreground.;
        }

        private void Shrift(object sender, RoutedEventArgs e)
        {
            
        }

        private void Text(DependencyProperty property, object value)
            {
                if (value!= null)
                {
                    TextBox.SelectionBrush.ApplyAnimationClock (property, null);
                }
            }

        private void Clean(object sender, RoutedEventArgs e) => TextBox.Clear();

        private void Exit(object sender, RoutedEventArgs e) => Close();

        private void Color1(object sender, RoutedEventArgs e)
        {

        }

        private void Color2(object sender, RoutedEventArgs e)
        {

        }

        private void Shrift1(object sender, RoutedEventArgs e) => TextBox.FontStyle = FontStyles.Italic;

        private void Shrift2(object sender, RoutedEventArgs e)
        {
            TextBox.FontStyle = FontStyles.
        }

        private void Text1(object sender, RoutedEventArgs e)
        {

        }

        private void Text2(object sender, RoutedEventArgs e)
        {

        }
    }
}
