using AsyncProgrammingApp.DTO;
using AsyncProgrammingApp.Services;
using System.Net.Http;
using System.Printing;
using System.Text;
using System.Text.Json;
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

namespace AsyncProgrammingApp
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

        private void btnPrintSync_Click(object sender, RoutedEventArgs e)
        {
            PrinterService obj = new PrinterService();
            obj.Print(10);
            MessageBox.Show("end of click(blocking)");
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello how are you");
        }

        private void btnThread_Click(object sender, RoutedEventArgs e)
        {
            PrinterService obj = new PrinterService();
            obj.PrintViaThread();//async ,got to next line
            MessageBox.Show("end of click(non blocking)");
        }

        private void btnTask_Click(object sender, RoutedEventArgs e)
        {
            PrinterService obj = new PrinterService();
            obj.PrintViaTask();
            MessageBox.Show("end of click(non blocking)");

        }

      

        private  async void btnAwaitable_Click(object sender, RoutedEventArgs e)
        {
            PrinterService obj = new PrinterService();
            await obj.PrintViaTaskWithAwaitable();
            MessageBox.Show("end of click after 10 secnds");
        }

        private async void btnWithResult_Click(object sender, RoutedEventArgs e)
        {
            PrinterService obj = new PrinterService();
           string result=  await obj.PrintViaTaskWithAwaitableResult();
            MessageBox.Show("end of click after 10 secnds :"+ result);
        }

        private async void btnRestAPI_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string url = "https://ks-testapi-keonig.azurewebsites.net/api/v1/WeatherForecast";
                HttpClient client = new HttpClient();
                string result = await client.GetStringAsync(url);
                List<WeatherData> weatherList = JsonSerializer.Deserialize<List<WeatherData>>(result);

                MessageBox.Show(weatherList.Count + " ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}