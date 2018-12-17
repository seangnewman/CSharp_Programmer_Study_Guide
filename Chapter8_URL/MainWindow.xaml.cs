using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Chapter8_URL
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

        private  async void Button_Click(object sender, RoutedEventArgs e)
        {
             string name = txtURL.Text;
            string  htmlValue = await ReturnHTML(name);
            urlLabel.Content = htmlValue.ToString();
        }

        public static Task<string> ReturnHTML(string url)
        {
            Task<string> task = Task.Run(() =>
            {
                if (!string.IsNullOrWhiteSpace(url))
                {
                    using (HttpClient client = new HttpClient())
                    using (HttpResponseMessage response = client.GetAsync(url).Result)
                    using (HttpContent content = response.Content)
                    {
                        return content.ReadAsStringAsync().Result;
                    }
                }

                return string.Empty;
            
            });

            return task;

        }
    }
}
 
