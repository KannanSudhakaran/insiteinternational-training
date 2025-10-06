using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEventsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnHello.Click += F1;
            btnHello.Click += F2;

            btnExit.Click += F3;
        }


        private void F1(object sender, RoutedEventArgs e) {

            MessageBox.Show("God is observing");
        }

        private void F2(object sender, RoutedEventArgs e) {

            MessageBox.Show("Devil is observing");
        }

        private void F3(object sender,RoutedEventArgs e) {

            this.Close();
        }
    }
}