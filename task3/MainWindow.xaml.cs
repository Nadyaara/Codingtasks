using System;
using System.Data;
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

namespace task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a = 0;
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in Pole.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "C")
            {
                text.Text = "";
                a = 0;
            }
            else if (str == ".")
            {
                if (a == 0)
                {
                    text.Text += str;
                    a += 1;
                }
            }

            else if (str == "=")
            {
                string value = new DataTable().Compute(text.Text, null).ToString();
                text.Text = value;
                a = 0;
            }
            else if (str == "+" || str == "*" || str == "/" || str == "-" || str == "^")
            {
                a = 0;
                text.Text += str;
            }
            else
                text.Text += str;
        }
    }
}
