using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Comparaciones
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DateTime primero;
        private DateTime segundo;

        public MainWindow()
        {
            InitializeComponent();

            primero = DateTime.Now;
            segundo = DateTime.Now;

            fechaPrimera.Text = primero.ToString("d MMMM yyyy");
            fechaSegunda.Text = segundo.ToString("d MMMM yyyy");
        }

        private void firstDateAdjusterValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            primero = DateTime.Now.AddDays(e.NewValue);
            fechaPrimera.Text = primero.ToString("d MMMM yyyy");
        }

        private void secondDateAdjusterValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            segundo = DateTime.Now.AddDays(e.NewValue);
            fechaSegunda.Text = segundo.ToString("d MMMM yyyy");
        }

        private void compareClick(object sender, RoutedEventArgs e)
        {
            int diff = dateCompare(primero, segundo);
            info.Text = "";
            show("fechaPrimera == fechaSegunda", diff == 0);
            show("fechaPrimera != fechaSegunda", diff != 0);
            show("fechaPrimera <  fechaSegunda", diff < 0);
            show("fechaPrimera <= fechaSegunda", diff <= 0);
            show("fechaPrimera >  fechaSegunda", diff > 0);
            show("fechaPrimera >= fechaSegunda", diff >= 0);
        }

        private void show(string exp, bool result)
        {
            info.Text += exp;
            info.Text += " : " + result.ToString();
            info.Text += "\n";
        }

        private int dateCompare(DateTime ladoIzquierdo, DateTime ladoDerecho)
        {
            int result;

            if (ladoIzquierdo.Year < ladoDerecho.Year)
            {
                result = -1;
            }
            else if (ladoIzquierdo.Year > ladoDerecho.Year)
            {
                result = 1;
            }

            else if (ladoIzquierdo.Month < ladoDerecho.Month)
            {
                result = -1;
            }
            else if (ladoIzquierdo.Month > ladoDerecho.Month)
            {
                result = 1;
            }

            else if (ladoIzquierdo.Day < ladoDerecho.Day)
            {
                result = -1;
            }
            else if (ladoIzquierdo.Day > ladoDerecho.Day)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}





































