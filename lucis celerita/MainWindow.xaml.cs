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

namespace lucis_celerita
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            double distancia1, distancia2, distanciatotal;
            double tempoemsegundo;
            double lux = 300000;

            distancia1 = Convert.ToDouble(txtInputvalor.Text);
            distancia2 = Convert.ToDouble(txtInputvalor2.Text);

            if (distancia1 > distancia2)
            {
                distanciatotal = distancia1 - distancia2;


                tempoemsegundo = distanciatotal / lux;


                TimeSpan time = TimeSpan.FromSeconds(tempoemsegundo);
                DateTime dateTime = DateTime.Today.Add(time);
                string displayTime = dateTime.ToString("hh:mm:tt");
                txtOutputvalor.Text = Convert.ToString(dateTime);
            }
            else if (distancia2 > distancia1)
            {
                distanciatotal = distancia2 - distancia1;


                tempoemsegundo = distanciatotal / lux;


                 TimeSpan time = TimeSpan.FromSeconds(tempoemsegundo);
                DateTime dateTime = DateTime.Today.Add(time);
                string displayTime = dateTime.ToString("hh:mm:tt");
                txtOutputvalor.Text = Convert.ToString(dateTime);

            }

        }

    }
}
