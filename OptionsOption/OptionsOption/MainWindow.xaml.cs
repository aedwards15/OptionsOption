using System;
using System.Windows;
using System.Net;
using System.IO;
using System.Text;


namespace OptionsOption
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://sandbox.tradier.com/v1/markets/quotes?symbols=AAPL,VXX190517P00016000");
            request.Method = "GET";
            request.Headers["Authorization"] = "Bearer <token>";
            request.Accept = "application/json";

            var response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(response.StatusCode);
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseString);
        }
    }
}
