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
            List<string[]> abvg = new List <string[]>();
            abvg.Add(new string[] { "шашлык", "250" });
            abvg.Add(new string[] { "роллы", "500" });
            abvg.Add(new string[] { "пицца", "450" });
            asd.ItemsSource = abvg;

        }

    }
}
