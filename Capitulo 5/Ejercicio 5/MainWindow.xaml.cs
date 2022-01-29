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

namespace Ejercicio_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    /*
     Hacer una función que dado un número
     nos regrese una cadena donde se
     encuentre escrito en palabras

    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Calcular_Click(object sender, RoutedEventArgs e)
        {

            Numero();


        }

        public void Numero()
        {

            int numero = int.Parse(pantalla.Text);
            pantalla.Text = " ";
            pantalla2.Items.Clear();
            string cadena = numero.ToString();



            if (numero == 1)
            {
                pantalla2.Items.Add("Uno");

            }
            if (numero == 2)
            {
                pantalla2.Items.Add("Dos");
            }

            if (numero == 3)
            {
                pantalla2.Items.Add("Tres");
            }

            if (numero == 4)
            {
                pantalla2.Items.Add("Cuatro");
            }

            if (numero == 5)
            {
                pantalla2.Items.Add("Cinco");
            }

            if (numero == 6)
            {
                pantalla2.Items.Add("Seis");
            }

            if (numero == 7)
            {
                pantalla2.Items.Add("Siete");
            }

            if (numero == 8)
            {
                pantalla2.Items.Add("Ocho");
            }

            if (numero == 9)
            {
                pantalla2.Items.Add("Nueve");
            }

            if (numero == 10)
            {
                pantalla2.Items.Add("Diez");
            }

            if (numero == 11)
            {
                pantalla2.Items.Add("Onces");
            }

            if (numero == 12)
            {
                pantalla2.Items.Add("Doces");
            }

            if (numero == 13)
            {
                pantalla2.Items.Add("Trece");
            }

            if (numero == 14)
            {
                pantalla2.Items.Add("Catorce");
            }

            if (numero == 15)
            {
                pantalla2.Items.Add("Quince");
            }


        }
    }
}
