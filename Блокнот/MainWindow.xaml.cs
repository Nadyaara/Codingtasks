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
using System.Drawing;

namespace Блокнот
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool a = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Color(object sender, RoutedEventArgs e) //фон и цвет
        {
            TextBox.Foreground = Brushes.Black;
            TextBox.Background = Brushes.White;
        }

        private void Shrift(object sender, RoutedEventArgs e) //жирный
        {
            a = !a;
            if (a)

            {
                TextBox.FontWeight = FontWeight.FromOpenTypeWeight(999);
            }
            else
            {
                TextBox.FontWeight = FontWeight.FromOpenTypeWeight(32);
            }
        }

        private void Clean(object sender, RoutedEventArgs e) => TextBox.Clear();  //очистить

        private void Exit(object sender, RoutedEventArgs e) => Close();    //закрыть

        private void Color1(object sender, RoutedEventArgs e) //фон и цвет
        {
            TextBox.Foreground = Brushes.White;
            TextBox.Background = Brushes.Black;
        }

        private void Color2(object sender, RoutedEventArgs e)  //фон и цвет
        {
            TextBox.Foreground = Brushes.Yellow;
            TextBox.Background = Brushes.Black;
        }

        private void Shrift1(object sender, RoutedEventArgs e)

        {
            a = !a;
            if (a)

            {
                TextBox.FontStyle = FontStyles.Italic; //косой
            }
            else
            {
                TextBox.FontStyle = FontStyles.Normal;
            }
        }

          
        private void Shrift2(object sender, RoutedEventArgs e)
        {
                a = !a;
                if (a)

                {
                     TextBox.TextDecorations = TextDecorations.Underline;//подчеркивание
                }
                else
                {
                TextBox.TextDecorations = null;
                }
        }

        private void Font4_Click(object sender, RoutedEventArgs e) //Шрифт1
        {
            TextBox.FontFamily = new FontFamily("Comic Sans MS");
        }

        private void Button_Click(object sender, RoutedEventArgs e)//Шрифт2
        {
            TextBox.FontFamily = new FontFamily("Times News Roman");
        }

        private void Font3_Click(object sender, RoutedEventArgs e)//Шрифт3
        {
            TextBox.FontFamily = new FontFamily("Viner Hand ITC");
        }
    }
}
