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

namespace Ejercicio_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /*
          Hacer un programa que muestre la tabla
          de multiplicar del 1 al 10 de cualquier
          número.

    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            string m = pantalla.Text;
            int numero = int.Parse(m);
            int resultado;
            if (numero > 10 || numero < 1)
            {
                MessageBox.Show("Lamentablemnte el numero que a ingraso es mayor a 10 ingrea un numero igual a 10 o menor que 10");
                pantalla.Text="";
            }
            else
            {

                for (int i = 1; i <= 10; i++)
                {
                    resultado = numero * i;

                    pantalla2.Items.Add($"El resulatado de {numero} x {i} = " + resultado);
                    
                }
            }




        }
    }
}
