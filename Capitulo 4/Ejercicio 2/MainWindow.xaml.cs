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

namespace Ejercicio_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /*
        Hacer un programa que calcule el
        resultado de un número elevado a
        cualquier potencia
    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

         private void Calcular_Click(object sender, RoutedEventArgs e){

           int Base = int.Parse(pantalla.Text);
           int Exponencial = int.Parse(pantalla2.Text);
           int suma=1;
          for(int i=0; i<Exponencial; i++)
          {

           suma=suma*Base;
            
         
          }
             pantalla3.Items.Add( suma);
        
         }
         
    }
}
