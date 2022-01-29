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

        Hacer un programa que calcule el
        promedio de edad de un grupo de
        personas y diga cuál es la de edad más
        grande y cuál es la más joven.

    */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Calcular_Click(object sender, RoutedEventArgs e)
        {

            Pantalla();

        }

        public void Pantalla()
        {
            int edad1 = int.Parse(pantalla1.Text);
            int edad2 = int.Parse(pantalla2.Text);
            int edad3 = int.Parse(pantalla3.Text);
            int promedio=0;

           if (edad1 > edad2 && edad1 > edad3)
            {
              
                pantalla4.Items.Add("El mayor es "+ edad1);
            }

            if (edad1 < edad2 && edad1 < edad3)
            {
          
                 pantalla4.Items.Add("El menor es "+ edad1);
            }

            if (edad2 > edad1 && edad2 > edad3)
            {
             
                 pantalla4.Items.Add("El mayor es "+ edad2);

            }

            if (edad2 < edad1 && edad2 < edad3)
            {
                
                pantalla4.Items.Add("El menor es "+ edad2);
            }

            if (edad3 > edad1 && edad3 > edad2)
            {
                 pantalla4.Items.Add("El mayor es "+ edad3);
            }

            if (edad3 < edad1 && edad3 < edad2)
            {
                 pantalla4.Items.Add("El menor es "+ edad3);
            }
            
            promedio=(edad1+edad2+edad3)/3;
             pantalla4.Items.Add("El promedio es de "+ promedio);



        }


    }
}

