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

namespace Cartas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const int NumManos = 4;
        private Pack pack = null;
        private Mano[] manos = { new Mano(), new Mano(), new Mano(), new Mano() };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void dealClick(object sender, RoutedEventArgs e)
        {
            try
            {
                pack = new Pack();

                for (int numMano = 0; numMano < NumManos; numMano++)
                {
                    manos[numMano] = new Mano();
                    for (int numCartas = 0; numCartas < Mano.TamMano; numCartas++)
                    {
                        Carta repartoCarta = pack.RepartirCartaDePack();
                        manos[numMano].AdcartaAMano(repartoCarta);
                    }
                }

                norte.Text = manos[0].ToString();
                sur.Text = manos[1].ToString();
                este.Text = manos[2].ToString();
                oeste.Text = manos[3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
