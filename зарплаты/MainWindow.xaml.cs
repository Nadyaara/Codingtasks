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

namespace зарплаты
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
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (Radio_seller.IsChecked.Value)
            {

                try
                {
                    //Новый объект класса продавец
                    Class_seller mySeller = new Class_seller();

                    //вызываем метод
                    //начальная зп продавца

                    mySeller.SetBasicSalary(Double.Parse(TextBase.Text));
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + mySeller.GetSalary(Convert.ToInt32(TextShift.Text)); //получаем зп
                    Stack_Seller.Children.Add(myTextBlock);
                }
                catch (Exception )
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
            if (Radio_mainseller.IsChecked.Value)
            {
                try
                {
                    Class_mainseller mySenior = new Class_mainseller();
                    mySenior.SetBasicSalary(Double.Parse(TextBase.Text));
                    mySenior.P(Double.Parse(TextMargin.Text));
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + mySenior.GetSalary(Convert.ToInt32(TextShift.Text));
                    Stack_mainseller.Children.Add(myTextBlock);
                }
                catch (Exception )
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
            if (Radio_manager.IsChecked.Value)
            {
                try
                {
                    Class_manager myManager = new Class_manager();
                    myManager.SetBasicSalary(Double.Parse(TextBase.Text));
                    myManager.P(Double.Parse(TextMargin.Text));
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + myManager.GetSalary(Convert.ToInt32(TextShift.Text));
                    Stack_manager.Children.Add(myTextBlock);
                }
                catch (Exception )
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
            if (Radio_driver.IsChecked.Value)
            {

                try
                {
                    Class_driver myDriver = new Class_driver();
                    myDriver.SetBasicSalary(Double.Parse(TextBase.Text));
                    TextBlock myTextBlock = new TextBlock();
                    myTextBlock.Text = "Зарплата: " + myDriver.GetSalary(Convert.ToInt32(TextShift.Text));
                    Stack_driver.Children.Add(myTextBlock);
                }
                catch (Exception )
                {
                    LabelZpbaz.Foreground = Brushes.Red;
                }
            }
        }
        private void TextRadius_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LabelZpbaz.Foreground != Brushes.Black)
                LabelZpbaz.Foreground = Brushes.Black;
        }
    }
}