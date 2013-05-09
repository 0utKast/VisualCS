using System;
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


namespace DeclaracionSwitch
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

        private void copyClick(object sender, RoutedEventArgs e)
        {
            target.Text = "";
            string from = source.Text;
            for (int i = 0; i != from.Length; i++)
            {
                char current = from[i];
                copyOne(current);
            }
        }

        private void copyOne(char current)
        {
            switch (current)
            {
                case '<':
                    target.Text += "&lt;";
                    break;
                case '>':
                    target.Text += "&gt;";
                    break;
                case '&':
                    target.Text += "&amp;";
                    break;
                case '\"':
                    target.Text += "&#34;";
                    break;
                case '\'':
                    target.Text += "&#39;";
                    break;
                default:
                    target.Text += current;
                    break;
            }
        }
    }
}