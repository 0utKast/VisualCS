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

namespace Methods
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
      
        private void calculateClick(object sender, RoutedEventArgs e)
        {
            int calculatedValue = 0;

            try
            {
                int leftHandSide = System.Int32.Parse(lhsOperand.Text);
                int rightHandSide = System.Int32.Parse(rhsOperand.Text);

                if (addition.IsChecked.HasValue && addition.IsChecked.Value)
                {
                    calculatedValue = addValues(leftHandSide, rightHandSide);
                    mostrarResultado(calculatedValue);
                }
                else if (subtraction.IsChecked.HasValue && subtraction.IsChecked.Value)
                {
                    calculatedValue = subtractValues(leftHandSide, rightHandSide);
                    mostrarResultado(calculatedValue);
                }
                else if (multiplication.IsChecked.HasValue && multiplication.IsChecked.Value)
                {
                    calculatedValue = multiplyValues(leftHandSide, rightHandSide);
                    mostrarResultado(calculatedValue);
                }
                else if (division.IsChecked.HasValue && division.IsChecked.Value)
                {
                    calculatedValue = divideValues(leftHandSide, rightHandSide);
                    mostrarResultado(calculatedValue);
                }
                else if (remainder.IsChecked.HasValue && remainder.IsChecked.Value)
                {
                    calculatedValue = remainderValues(leftHandSide, rightHandSide);
                    mostrarResultado(calculatedValue);
                }
            }
            catch (Exception caught)
            {
                expression.Text = "";
                result.Text = caught.Message;
            }
        }

        private int addValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " + " + rightHandSide.ToString();
            return leftHandSide + rightHandSide;
        }

        private int subtractValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " - " + rightHandSide.ToString();
            return leftHandSide - rightHandSide;
        }

        private int multiplyValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " * " + rightHandSide.ToString();
            return leftHandSide * rightHandSide;
        }

        private int divideValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " / " + rightHandSide.ToString();
            return leftHandSide / rightHandSide;
        }

        private int remainderValues(int leftHandSide, int rightHandSide)
        {
            expression.Text = leftHandSide.ToString() + " % " + rightHandSide.ToString();
            return leftHandSide % rightHandSide;
        }

        private void mostrarResultado(int respuesta)
        {
            result.Text = respuesta.ToString();
        }

        private void quitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
