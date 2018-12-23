using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace Chap9_Image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            imgURL.Source = null;
        }

        private void btnURL_Click(object sender, RoutedEventArgs e)
        {
            var imageURL = "rc.bmp";
            byte[] imagebytes;

            using (var webClient = new WebClient())
            {
                imagebytes = webClient.DownloadData(imageURL);
            }

            File.WriteAllBytes("rc_copy.bmp", imagebytes);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //FileInfo file = new FileInfo(@"C:\Users\seang\source\repos\CSharp_Study_Guide\Chap9_Image\bin\Debug\rc_copy.bmp");
            string file = @"C:\Users\seang\source\repos\CSharp_Study_Guide\Chap9_Image\bin\Debug\rc_copy.bmp";
            BitmapImage img = new BitmapImage(new Uri("rc.bmp", UriKind.RelativeOrAbsolute));

            imgURL.Source = img;
        }
    }
}
