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

namespace Kalkulator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Content.ToString();
            numbers.Text += number;
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            int temp = int.Parse( numbers.Text);
            result.Text += temp;

            numbers.Text = string.Empty;
        }

        private void Button_ClickEquals(object sender, RoutedEventArgs e)
        {
            try
            {
                int equals = int.Parse(result.Text) + int.Parse(numbers.Text);

                result.Text = equals.ToString();

                numbers.Text = string.Empty;
            }catch (Exception ex)
            {

            }
        }
    }
}
