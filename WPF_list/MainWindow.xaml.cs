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

namespace WPF_list
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Here are my favorite movies:");
            Task.Delay(1000);
            Divider.Visibility = Visibility.Visible;
            MovieOne.Visibility = Visibility.Visible;
            MovieTwo.Visibility = Visibility.Visible;
            MovieThree.Visibility = Visibility.Visible;
            MovieFour.Visibility = Visibility.Visible;


        }
    }
}
