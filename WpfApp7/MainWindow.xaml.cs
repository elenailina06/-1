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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string[]> data = new List<string[]>();
            data.Add(new string[] { "Роллы ", "600" });
            data.Add(new string[] { "Пицца", " 500" });
            data.Add(new string[] { "шашлык", " 550" });

            asd.ItemsSource = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tabControl11.SelectedItem = tabControl11.Items[0];
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tabControl11.SelectedItem = tabControl11.Items[1];

        }
    }
}
