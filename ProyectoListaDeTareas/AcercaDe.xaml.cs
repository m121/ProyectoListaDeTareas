﻿using System;
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

namespace ProyectoListaDeTareas
{
    public partial class AcercaDe : PhoneApplicationPage
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        // Botón volver
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml",UriKind.Relative));

        }
    }
}
