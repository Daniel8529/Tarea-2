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

namespace Ejercicio_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /*
    Hacer una función que calcule el factorial
    de un número

    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {


             Factorial();

        }


        public void Factorial()
        {
          int factorial =int.Parse(pantalla.Text);
          int m=int.Parse(pantalla.Text);
         
          
            for (int i = factorial-1; i > 0; i--)
            {
               
               factorial=factorial*i;
            

                pantalla2.Items.Add($"Factorial de {m} x {i} ="+ factorial);
                 
            }

        }



    }
}
