using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Marketplace;
using Microsoft.Phone.Tasks;


namespace ProyectoListaDeTareas
{

    

    public partial class MainPage : PhoneApplicationPage
    {

        // Constructor
        public MainPage()
        {
            InitializeComponent();

   

                   
        }

       

        
        
        
      
         
       
        // botón agregar tarea
        private void BotonLista_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AgregarTarea.xaml", UriKind.Relative));
        }

        // botón abrir
        private void BotonAbrir_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Dia1.xaml", UriKind.Relative));
        }

        // botón Acerca de
        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AcercaDe.xaml", UriKind.Relative));
        }
    }
}