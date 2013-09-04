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
using System.Windows.Threading;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework;









namespace ProyectoListaDeTareas
{

    
    public partial class PhonePage1 : PhoneApplicationPage
    {
        




        public PhonePage1()
        {
            InitializeComponent();
            
            // temporizador 1
            temporizador1 = new System.Windows.Threading.DispatcherTimer();
            temporizador1.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador1.Tick += new EventHandler(temporizador1_tick);

            // temporizador 2
            temporizador2 = new System.Windows.Threading.DispatcherTimer();
            temporizador2.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador2.Tick += new EventHandler(temporizador2_tick);

            // temporizador 3
            temporizador3 = new System.Windows.Threading.DispatcherTimer();
            temporizador3.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador3.Tick += new EventHandler(temporizador3_tick);

            // temporizador 4
            temporizador4 = new System.Windows.Threading.DispatcherTimer();
            temporizador4.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador4.Tick += new EventHandler(temporizador4_tick);

            // temporizador 5
            temporizador5 = new System.Windows.Threading.DispatcherTimer();
            temporizador5.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador5.Tick += new EventHandler(temporizador5_tick);

            // temporizador 6
            temporizador6 = new System.Windows.Threading.DispatcherTimer();
            temporizador6.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador6.Tick += new EventHandler(temporizador6_tick);

            // temporizador 7
            temporizador7 = new System.Windows.Threading.DispatcherTimer();
            temporizador7.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador7.Tick += new EventHandler(temporizador7_tick);

            // temporizador 8
            temporizador8 = new System.Windows.Threading.DispatcherTimer();
            temporizador8.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador8.Tick += new EventHandler(temporizador8_tick);

            // temporizador 9
            temporizador9 = new System.Windows.Threading.DispatcherTimer();
            temporizador9.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador9.Tick += new EventHandler(temporizador9_tick);

            // temporizador 10
            temporizador10 = new System.Windows.Threading.DispatcherTimer();
            temporizador10.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador10.Tick += new EventHandler(temporizador10_tick);

            // temporizador 11
            temporizador11 = new System.Windows.Threading.DispatcherTimer();
            temporizador11.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador11.Tick += new EventHandler(temporizador11_tick);

            // temporizador 12
            temporizador12 = new System.Windows.Threading.DispatcherTimer();
            temporizador12.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador12.Tick += new EventHandler(temporizador12_tick);

            // Si se esta reproduciendo musica entonces pregunta si desea pararla o no
            if (Microsoft.Xna.Framework.Media.MediaPlayer.State == MediaState.Playing)
            {

                MessageBoxResult Choice;
                Choice = MessageBox.Show("Media se está reproduciendo en este momento, ¿quieres parar?", "Detener Reproductor", MessageBoxButton.OKCancel);
                if (Choice == MessageBoxResult.OK)
                {
                    try
                    {
                        FrameworkDispatcher.Update();

                        MessageBox.Show("¡Ahora media se detuvo! ");

                        Microsoft.Xna.Framework.Media.MediaPlayer.Stop();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                   
                {
                    
                    MessageBox.Show("¡Ahora la alarma no funciona!, pero la lista seguira funcionando normal, sin embargo despues de que termine el cronómetro pasará 14 segundos para que inicie la siguiente tarea");
                    NumeroMedia = 1;
                    
                      //  App.Current.EnabledSound = false;
                    
                }
            }


            
                 
        }



        // variables temporizador 1
        int horaUno = 0;
        int minutoUno = 0;
        int segundoUno = 0;
        int a = 0;

        // variables temporizador 2
        int horaDos = 0;
        int minutoDos = 0;
        int segundoDos = 0;
        int b = 0;

        // variables temporizador 3
        int horaTres = 0;
        int minutoTres = 0;
        int segundoTres = 0;
        int c = 0;

        // variables temporizador 4
        int horaCuatro = 0;
        int minutoCuatro = 0;
        int segundoCuatro = 0;
        int d = 0;

        // variables temporizador 5
        int horaCinco = 0;
        int minutoCinco = 0;
        int segundoCinco = 0;
        int n = 0;

        // variables temporizador 6
        int horaSeis = 0;
        int minutoSeis = 0;
        int segundoSeis = 0;
        int f = 0;

        // variables temporizador 7
        int horaSiete = 0;
        int minutoSiete = 0;
        int segundoSiete = 0;
        int g = 0;

        // variables temporizador 8
        int horaOcho = 0;
        int minutoOcho = 0;
        int segundoOcho = 0;
        int h = 0;

        // variables temporizador 9
        int horaNueve = 0;
        int minutoNueve = 0;
        int segundoNueve = 0;
        int i = 0;

        // variables temporizador 10
        int horaDiez = 0;
        int minutoDiez = 0;
        int segundoDiez = 0;
        int j = 0;

        // variables temporizador 11
        int horaOnce= 0;
        int minutoOnce = 0;
        int segundoOnce = 0;
        int k = 0;

        // variables temporizador 12
        int horaDoce = 0;
        int minutoDoce = 0;
        int segundoDoce = 0;
        int l = 0;


        // Media numero para reproducir o no la alarma si se esta escuchando música

        int NumeroMedia = 0;

       

        System.Windows.Threading.DispatcherTimer temporizador1;
        System.Windows.Threading.DispatcherTimer temporizador2;
        System.Windows.Threading.DispatcherTimer temporizador3;
        System.Windows.Threading.DispatcherTimer temporizador4;
        System.Windows.Threading.DispatcherTimer temporizador5;
        System.Windows.Threading.DispatcherTimer temporizador6;
        System.Windows.Threading.DispatcherTimer temporizador7;
        System.Windows.Threading.DispatcherTimer temporizador8;
        System.Windows.Threading.DispatcherTimer temporizador9;
        System.Windows.Threading.DispatcherTimer temporizador10;
        System.Windows.Threading.DispatcherTimer temporizador11;
        System.Windows.Threading.DispatcherTimer temporizador12;
        
        
         
    

        int valor = 0;





        

       






           






        


        // Temporizador 1
        public void temporizador1_tick(object sender, EventArgs e)
        {
            if (a != 00)
            {
                a--;


            }



            segundoUno = a;

            if (segundoUno == 00)
            {
                if (minutoUno != 00)
                {
                    segundoUno = 59;
                    minutoUno--;
                    a = segundoUno;


                }

                if ((horaUno != 00) && (minutoUno == 00))
                {
                    horaUno--;
                    minutoUno = 59;
                    minutoUno--;
                    segundoUno = 59;
                    a = segundoUno;
                }




                if ((segundoUno == 00) && (horaUno == 00) && (minutoUno == 00))
                {





                                segundoUno = 0;
                                temporizador1.Stop();
                                if (NumeroMedia == 0)
                                {
                                    MediaElementAlarma.Play();
                                }
                                else
                                {
                                    MediaElementAlarma.Stop();
                                }
                                temporizador2.Start();
                                System.Threading.Thread.Sleep(18000);


                    
                } 
                        
                            
                        
                        
                    
                    
     
            }







            Crono1.Text = horaUno + ":" + minutoUno + ":" + segundoUno;
            CronoUni.Text = horaUno + ":" + minutoUno + ":" + segundoUno;






        }
        
        // Temporizador 2
        int numeroDos = 0;
        public void temporizador2_tick(object sender, EventArgs e)
        {
            if ((segundoDos != 00) || (horaDos != 00) || (minutoDos != 00))
            {
                numeroDos = 1;
            }

            if (b != 00)
            {
                b--;


            }



            segundoDos = b;

            if (segundoDos == 00)
            {
                if (minutoDos != 00)
                {
                    segundoDos = 59;
                    minutoDos--;
                    b = segundoDos;


                }

                if ((horaDos != 00) && (minutoDos == 00))
                {
                    horaDos--;
                    minutoDos = 59;
                    segundoDos = 59;
                    b = segundoDos;
                }

                if ((segundoDos == 00) && (horaDos == 00) && (minutoDos == 00))
                {

                    if (numeroDos == 1)
                    {
                        temporizador2.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                        temporizador3.Start();
                        System.Threading.Thread.Sleep(18000);
                            



                        
                       
                        
                            

                        
                        
                        
                    }
                    
                    
                        

                    }
                    segundoDos = 0;
                


            }




            Crono2.Text = horaDos + ":" + minutoDos + ":" + segundoDos;
            CronoUni.Text = horaDos + ":" + minutoDos + ":" + segundoDos;
            

        }
        
        // Temporizador 3
        int numeroTres = 0;
        public void temporizador3_tick(object sender, EventArgs e)
        {
            if ((segundoTres != 00) || (horaTres != 00) || (minutoTres != 00))
            {
                numeroTres = 1;
            }
            if (c != 00)
            {
                c--;


            }



            segundoTres = c;

            if (segundoTres == 00)
            {
                if (minutoTres != 00)
                {
                    segundoTres = 59;
                    minutoTres--;
                    c = segundoTres;


                }

                if ((horaTres != 00) && (minutoTres == 00))
                {
                    horaTres--;
                    minutoTres = 59;
                    segundoTres = 59;
                    c = segundoTres;
                }



                if ((segundoTres == 00) && (horaTres == 00) && (minutoTres == 00))
                {
                    if (numeroTres == 1)
                    {

                        //   segundoTres = 1;
                        temporizador3.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                        temporizador4.Start();
                        System.Threading.Thread.Sleep(18000);   

                        
                        
                        
                    
                    
                        
                    }

                    
                    
                    

                }
                segundoTres = 0;
            }




            Crono3.Text = horaTres + ":" + minutoTres + ":" + segundoTres;
            CronoUni.Text = horaTres + ":" + minutoTres + ":" + segundoTres;

           
        }
       
        // Temporizador 4
        int numeroCuatro = 0;
        public void temporizador4_tick(object sender, EventArgs e)
        {
            if ((segundoCuatro != 00) || (horaCuatro != 00) || (minutoCuatro != 00))
            {
                numeroCuatro = 1;
            }
            
            if (d != 00)
            {
                d--;


            }



            segundoCuatro = d;

            if (segundoCuatro == 00)
            {
                if (minutoCuatro != 00)
                {
                    segundoCuatro = 59;
                    minutoCuatro--;
                    d = segundoCuatro;


                }

                if ((horaCuatro != 00) && (minutoCuatro == 00))
                {
                    horaCuatro--;
                    minutoCuatro = 59;
                    segundoCuatro = 59;
                    d = segundoCuatro;
                }

                if ((segundoCuatro == 00) && (horaCuatro == 00) && (minutoCuatro == 00))
                {
                    if (numeroCuatro == 1)
                    {
                    
                        temporizador4.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                        temporizador5.Start();
                        System.Threading.Thread.Sleep(18000);


                        
                        
                        
                            

                        
                        
                        
                    }


                  
                       
                     
                    

                    
                }
                segundoCuatro = 0;

            }




            Crono4.Text = horaCuatro + ":" + minutoCuatro + ":" + segundoCuatro;
            CronoUni.Text = horaCuatro + ":" + minutoCuatro + ":" + segundoCuatro;
            
        }
        // Temporizador 5
        int numeroCinco = 0;
        public void temporizador5_tick(object sender, EventArgs e)
        {
            if ((segundoCinco != 00) || (horaCinco != 00) || (minutoCinco != 00))
            {
                numeroCinco = 1;
            }
            
            if (n != 00)
            {
                n--;


            }



            segundoCinco = n;

            if (segundoCinco == 00)
            {
                if (minutoCinco != 00)
                {
                    segundoCinco = 59;
                    minutoCinco--;
                    n = segundoCinco;


                }

                if ((horaCinco != 00) && (minutoCinco == 00))
                {
                    horaCinco--;
                    minutoCinco = 59;
                    segundoCinco = 59;
                    n = segundoCinco;
                }

                if ((segundoCinco == 00) && (horaCinco == 00) && (minutoCinco == 00))
                {
                    if (numeroCinco == 1)
                    {

                        temporizador5.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                        temporizador6.Start();
                        System.Threading.Thread.Sleep(18000);


                        
                            



                        
                        
                            
                    }
                   
                }
                segundoCinco = 0;
               
            }




            Crono5.Text = horaCinco + ":" + minutoCinco + ":" + segundoCinco;
            CronoUni.Text = horaCinco + ":" + minutoCinco + ":" + segundoCinco;
        
        }
        // Temporizador 6
        int numeroSeis = 0;
        public void temporizador6_tick(object sender, EventArgs e)
        {
            if ((segundoSeis != 00) || (horaSeis != 00) || (minutoSeis != 00))
            {
                numeroSeis = 1;
            }

            
            if (f != 00)
            {
                f--;


            }



            segundoSeis = f;

            if (segundoSeis == 00)
            {
                if (minutoSeis != 00)
                {
                    segundoSeis = 59;
                    minutoSeis--;
                    f = segundoSeis;


                }

                if ((horaSeis != 00) && (minutoSeis == 00))
                {
                    horaSeis--;
                    minutoSeis = 59;
                    segundoSeis = 59;
                    f = segundoSeis;
                }

                if ((segundoSeis == 00) && (horaSeis == 00) && (minutoSeis == 00))
                {
                    if (numeroSeis == 1)
                    {
                        MediaElementAlarma.Stop();
                        segundoSeis = 0;
                        temporizador6.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                         temporizador7.Start();
                        System.Threading.Thread.Sleep(18000);       
                           



                      
                            

                       
                        
                        
                    }
                    

                    
                }
                segundoSeis = 0;
                

            }




            Crono6.Text = horaSeis + ":" + minutoSeis + ":" + segundoSeis;
            CronoUni.Text = horaSeis + ":" + minutoSeis + ":" + segundoSeis;
       
        }
        // Temporizador 7
        int numeroSiete= 0;
        public void temporizador7_tick(object sender, EventArgs e)
        {
            if ((segundoSiete != 00) || (horaSiete != 00) || (minutoSiete != 00))
            {
                numeroSiete = 1;
            }
            
            if (g != 00)
            {
                g--;


            }



            segundoSiete = g;

            if (segundoSiete == 00)
            {
                if (minutoSiete != 00)
                {
                    segundoSiete = 59;
                    minutoSiete--;
                    g = segundoSiete;


                }

                if ((horaSiete != 00) && (minutoSiete == 00))
                {
                    horaSiete--;
                    minutoSiete = 59;
                    segundoSiete = 59;
                    g = segundoSiete;
                }

                if ((segundoSiete == 00) && (horaSiete == 00) && (minutoSiete == 00))
                {
                    if (numeroSiete == 1)
                    {

                        
                        temporizador7.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                         temporizador8.Start();
                        System.Threading.Thread.Sleep(18000);

                        
                        
                            

                        
                       
                    }
                   
                }
                segundoSiete = 0;

                
            }




            Crono7.Text = horaSiete + ":" + minutoSiete + ":" + segundoSiete;
            CronoUni.Text = horaSiete + ":" + minutoSiete + ":" + segundoSiete;
            
        }
        // Temporizador 8
        int numeroOcho = 0;
        public void temporizador8_tick(object sender, EventArgs e)
        {
            if ((segundoOcho != 00) || (horaOcho != 00) || (minutoOcho == 00))
            {
                numeroOcho = 1;
            }
            
            if (h != 00)
            {
                h--;


            }



            segundoOcho = h;

            if (segundoOcho == 00)
            {
                if (minutoOcho != 00)
                {
                    segundoOcho = 59;
                    minutoOcho--;
                    h = segundoOcho;


                }

                if ((horaOcho != 00) && (minutoOcho == 00))
                {
                    horaOcho--;
                    minutoOcho = 59;
                    segundoOcho = 59;
                    h = segundoOcho;
                }

                if ((segundoOcho == 00) && (horaOcho == 00) && (minutoOcho == 00))
                {
                    if (numeroOcho == 1)
                    {
                        
                        temporizador8.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                        temporizador9.Start();
                        System.Threading.Thread.Sleep(18000);


                        
                        
                            
                        
                        
                       
                    }
                    
                }
                segundoOcho = 0;

                
            }




            Crono8.Text = horaOcho + ":" + minutoOcho + ":" + segundoOcho;
            CronoUni.Text = horaOcho + ":" + minutoOcho + ":" + segundoOcho;
           
        }
        // Temporizador 9
        int numeroNueve = 0;
        public void temporizador9_tick(object sender, EventArgs e)
        {
            if ((segundoNueve != 00) || (horaNueve != 00) || (minutoNueve != 00))
            {
                numeroNueve = 1;
            }
           
            if (i != 00)
            {
                i--;


            }



            segundoNueve = i;

            if (segundoNueve == 00)
            {
                if (minutoNueve != 00)
                {
                    segundoNueve = 59;
                    minutoNueve--;
                    i = segundoNueve;


                }

                if ((horaNueve != 00) && (minutoNueve == 00))
                {
                    horaNueve--;
                    minutoNueve = 59;
                    segundoNueve = 59;
                    i = segundoNueve;
                }


                if ((segundoNueve == 00) && (horaNueve == 00) && (minutoNueve == 00))
                {
                    if (numeroNueve == 1)
                    {
                        
                        temporizador9.Stop();

                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                            temporizador10.Start();
                            System.Threading.Thread.Sleep(18000);
                        
                        
                        
                    }
                    
                }
                segundoNueve = 0;

                
            }




            Crono9.Text = horaNueve + ":" + minutoNueve + ":" + segundoNueve;
            CronoUni.Text = horaNueve + ":" + minutoNueve + ":" + segundoNueve;
            
        }
        // Temporizador 10
        int numeroDiez= 0;
        public void temporizador10_tick(object sender, EventArgs e)
        {
            if ((segundoDiez != 00) || (horaDiez != 00) || (minutoDiez != 00))
            {
                numeroDiez = 1;
            }

            
            if (j != 00)
            {
                j--;


            }



            segundoDiez = j;

            if (segundoDiez == 00)
            {
                if (minutoDiez != 00)
                {
                    segundoDiez = 59;
                    minutoDiez--;
                    j = segundoDiez;


                }

                if ((horaDiez != 00) && (minutoDiez == 00))
                {
                    horaDiez--;
                    minutoDiez = 59;
                    segundoDiez = 59;
                    j = segundoDiez;
                }

                if ((segundoDiez == 00) && (horaDiez == 00) && (minutoDiez == 00))
                {
                    if (numeroDiez == 1)
                    {
                        
                        temporizador10.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                        temporizador11.Start();
                        System.Threading.Thread.Sleep(18000);
                            

                        
                        
                    }
                    
                }
                segundoDiez = 0;

               
            }




            Crono10.Text = horaDiez + ":" + minutoDiez + ":" + segundoDiez;
            CronoUni.Text = horaDiez + ":" + minutoDiez + ":" + segundoDiez;
            
        }
        // Temporizador 11
        int numeroOnce = 0;
        public void temporizador11_tick(object sender, EventArgs e)
        {
            if ((segundoOnce != 00) || (horaOnce != 00) || (minutoOnce != 00))
            {
                numeroOnce = 1;
            }
            
            if (k != 00)
            {
                k--;


            }



            segundoOnce = k;

            if (segundoOnce == 00)
            {
                if (minutoOnce != 00)
                {
                    segundoOnce = 59;
                    minutoOnce--;
                    k = segundoOnce;


                }

                if ((horaOnce != 00) && (minutoOnce == 00))
                {
                    horaOnce--;
                    minutoOnce = 59;
                    segundoOnce = 59;
                    k = segundoOnce;
                }

                if ((segundoOnce == 00) && (horaOnce == 00) && (minutoOnce == 00))
                {
                    if (numeroOnce == 1)
                    {
                       
                        temporizador11.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                        temporizador12.Start();
                        System.Threading.Thread.Sleep(18000);
                        
                            

                       
                        
                        
                    }
                    

                }
                segundoOnce = 0;

                
            }




            Crono11.Text = horaOnce + ":" + minutoOnce + ":" + segundoOnce;
            CronoUni.Text = horaOnce + ":" + minutoOnce + ":" + segundoOnce;
           
        }
        // Temporizador 12
        int numeroDoce = 0;
        public void temporizador12_tick(object sender, EventArgs e)
        {
            if ((segundoDoce != 00) || (horaDoce != 00) || (minutoDoce != 00))
            {
                numeroDoce = 1;
            }
                 
            
            if (l != 00)
            {
                l--;


            }



            segundoDoce = l;

            if (segundoDoce == 00)
            {
                if (minutoDoce != 00)
                {
                    segundoDoce = 59;
                    minutoDoce--;
                    l = segundoDoce;


                }

                if ((horaDoce != 00) && (minutoDoce == 00))
                {
                    horaDoce--;
                    minutoDoce = 59;
                    segundoDoce = 59;
                    l = segundoDoce;
                }

                if ((segundoDoce == 00) && (horaDoce == 00) && (minutoDoce == 00))
                {
                    if (numeroDoce == 1)
                    {
                        
                        temporizador12.Stop();
                        if (NumeroMedia == 0)
                        {
                            MediaElementAlarma.Play();
                        }
                        else
                        {
                            MediaElementAlarma.Stop();
                        }
                        
                           

                        
                      
                    }
                    

                }
                segundoDoce = 0;
                

                
            }




            Crono12.Text = horaDoce + ":" + minutoDoce + ":" + segundoDoce;
            CronoUni.Text = horaDoce + ":" + minutoDoce + ":" + segundoDoce;
            
        }

       
        
        // boton agregar tareas
       private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            try
            {
                valor++;
                using (BaseListasDataContext contextoDatos = new BaseListasDataContext("Data source='isostore:/ListasDB.sdf'"))
                {

                    //     misListas = contextoDatos.Lista.ToList();

                    var cont = contextoDatos.Lista.Where(c => c.Id == valor).FirstOrDefault();

                    if (cont != null)
                    {
                      

                        // agregar tarea 1

                        if (valor == 1)
                        {

                              Tarea1.Text = cont.Tarea;
                              
                              horaUno = Convert.ToInt32(cont.Hora);
                              minutoUno = Convert.ToInt32(cont.Minuto);
                              segundoUno = Convert.ToInt32(cont.Segundo);
                              a = Convert.ToInt32(cont.Segundo);


                              if ((Tarea1.Text).Length != 0)
                              {
                                  temporizador1.Start();
                              }
                              else
                              {
                                  contextoDatos.DeleteDatabase();
                                  MessageBox.Show("¡Todavia no has creado ninguna lista!");
                                       
                                  valor = 0;
                                  Tarea1.Text = "_______________________________________";

                                  Crono1.Text = "00:00:00";
                                  
                                    NavigationService.Navigate(new Uri("/AgregarTarea.xaml", UriKind.Relative));
                                  temporizador1.Stop();
                              }


                              

                        }

                        // agregar tarea 2

                        if (valor == 2)
                        {
                            Tarea2.Text = cont.Tarea;
                            horaDos = Convert.ToInt32(cont.Hora);
                            minutoDos = Convert.ToInt32(cont.Minuto);
                            segundoDos = Convert.ToInt32(cont.Segundo);
                            b = Convert.ToInt32(cont.Segundo);
                            Crono2.Text = horaDos + ":" + minutoDos + ":" + segundoDos;
                        }

                        // agregar tarea 3

                        if (valor == 3)
                        {
                            Tarea3.Text = cont.Tarea;
                            horaTres = Convert.ToInt32(cont.Hora);
                            minutoTres = Convert.ToInt32(cont.Minuto);
                            segundoTres = Convert.ToInt32(cont.Segundo);
                            c = Convert.ToInt32(cont.Segundo);
                            Crono3.Text = horaTres + ":" + minutoTres + ":" + segundoTres;
                        }

                        // agregar tarea 4

                        if (valor == 4)
                        {
                            Tarea4.Text = cont.Tarea;
                            horaCuatro = Convert.ToInt32(cont.Hora);
                            minutoCuatro = Convert.ToInt32(cont.Minuto);
                            segundoCuatro = Convert.ToInt32(cont.Segundo);

                            d = Convert.ToInt32(cont.Segundo);
                            Crono4.Text = horaCuatro + ":" + minutoCuatro + ":" + segundoCuatro;


                        }

                        // agregar tarea 5

                        if (valor == 5)
                        {
                            Tarea5.Text = cont.Tarea;
                            horaCinco = Convert.ToInt32(cont.Hora);
                            minutoCinco = Convert.ToInt32(cont.Minuto);
                            segundoCinco = Convert.ToInt32(cont.Segundo);
                            n = Convert.ToInt32(cont.Segundo);
                            Crono5.Text = horaCinco + ":" + minutoCinco + ":" + segundoCinco;
                        }

                        // agregar tarea 6

                        if (valor == 6)
                        {
                            Tarea6.Text = cont.Tarea;
                            horaSeis = Convert.ToInt32(cont.Hora);
                            minutoSeis = Convert.ToInt32(cont.Minuto);
                            segundoSeis = Convert.ToInt32(cont.Segundo);
                            f = Convert.ToInt32(cont.Segundo);
                            Crono6.Text = horaSeis + ":" + minutoSeis + ":" + segundoSeis;
                        }

                        // agregar tarea 7

                        if (valor == 7)
                        {
                            Tarea7.Text = cont.Tarea;
                            horaSiete = Convert.ToInt32(cont.Hora);
                            minutoSiete = Convert.ToInt32(cont.Minuto);
                            segundoSiete = Convert.ToInt32(cont.Segundo);
                            g = Convert.ToInt32(cont.Segundo);
                            Crono7.Text = horaSiete + ":" + minutoSiete + ":" + segundoSiete;
                        }

                        // agregar tarea 8

                        if (valor == 8)
                        {
                            Tarea8.Text = cont.Tarea;
                            horaOcho = Convert.ToInt32(cont.Hora);
                            minutoOcho = Convert.ToInt32(cont.Minuto);
                            segundoOcho = Convert.ToInt32(cont.Segundo);
                            h = Convert.ToInt32(cont.Segundo);
                            Crono8.Text = horaOcho + ":" + minutoOcho + ":" + segundoOcho;
                        }

                        // agregar tarea 9

                        if (valor == 9)
                        {
                            Tarea9.Text = cont.Tarea;
                            horaNueve = Convert.ToInt32(cont.Hora);
                            minutoNueve = Convert.ToInt32(cont.Minuto);
                            segundoNueve = Convert.ToInt32(cont.Segundo);
                            i = Convert.ToInt32(cont.Segundo);
                            Crono9.Text = horaNueve + ":" + minutoNueve + ":" + segundoNueve;
                        }

                        // agregar tarea 10

                        if (valor == 10)
                        {
                            Tarea10.Text = cont.Tarea;
                            horaDiez = Convert.ToInt32(cont.Hora);
                            minutoDiez = Convert.ToInt32(cont.Minuto);
                            segundoDiez = Convert.ToInt32(cont.Segundo);
                            j = Convert.ToInt32(cont.Segundo);
                            Crono10.Text = horaDiez + ":" + minutoDiez + ":" + segundoDiez;
                        }

                        // agregar tarea 11

                        if (valor == 11)
                        {
                            Tarea11.Text = cont.Tarea;
                            horaOnce = Convert.ToInt32(cont.Hora);
                            minutoOnce = Convert.ToInt32(cont.Minuto);
                            segundoOnce = Convert.ToInt32(cont.Segundo);
                            k = Convert.ToInt32(cont.Segundo);
                            Crono11.Text = horaOnce + ":" + minutoOnce + ":" + segundoOnce;
                        }

                        // agregar tarea 12

                        if (valor == 12)
                        {
                            Tarea12.Text = cont.Tarea;
                            horaDoce = Convert.ToInt32(cont.Hora);
                            minutoDoce = Convert.ToInt32(cont.Minuto);
                            segundoDoce = Convert.ToInt32(cont.Segundo);
                            l = Convert.ToInt32(cont.Segundo);
                            Crono12.Text = horaDoce + ":" + minutoDoce + ":" + segundoDoce;
                        }

                       


                    }
                   
                   
                    cont = null;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("¡No puedes agregar tareas ya que no has creado ninguna lista !");

            }

        }
        
        
        




        // boton borrar
       private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
       {
           
           using (BaseListasDataContext dataContext1 = new BaseListasDataContext("Data source='isostore:/ListasDB.sdf'"))
           {
              
                   dataContext1.DeleteDatabase();
                   valor = 0;

                   // borrar tarea 1
                   
                   Tarea1.Text = "_______________________________________";

                   Crono1.Text = "00:00:00";

                   // borrar tarea 2

                   Tarea2.Text = "_______________________________________";

                   Crono2.Text = "00:00:00";

                   // borrar tarea 3

                   Tarea3.Text = "_______________________________________";

                   Crono3.Text = "00:00:00";

                   // borrar tarea 4

                   Tarea4.Text = "_______________________________________";

                   Crono4.Text = "00:00:00";

                   // borrar tarea 5

                   Tarea5.Text = "_______________________________________";

                   Crono5.Text = "00:00:00";

                   // borrar tarea 6

                   Tarea6.Text = "_______________________________________";

                   Crono6.Text = "00:00:00";

                   // borrar tarea 7

                   Tarea7.Text = "_______________________________________";

                   Crono7.Text = "00:00:00";

                   // borrar tarea 8

                   Tarea8.Text = "_______________________________________";

                   Crono8.Text = "00:00:00";

                   // borrar tarea 9

                   Tarea9.Text = "_______________________________________";

                   Crono9.Text = "00:00:00";

                   // borrar tarea 10

                   Tarea10.Text = "_______________________________________";

                   Crono10.Text = "00:00:00";

                   // borrar tarea 11

                   Tarea11.Text = "_______________________________________";

                   Crono11.Text = "00:00:00";

                   // borrar tarea 12

                   Tarea12.Text = "_______________________________________";

                   Crono12.Text = "00:00:00";
           }
           
           MessageBox.Show("La lista ha sido borrada ");
       }

        // botón atrás
       private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
       {
           NavigationService.Navigate(new Uri("/AgregarTarea.xaml", UriKind.Relative));
       }

        // botón guardar
       private void ApplicationBarIconButton_Click_3(object sender, EventArgs e)
       {
           using (BaseListasDataContext ContextoDatosGuardar = new BaseListasDataContext("Data source='isostore:/ListasDB.sdf'"))
           {
               if (ContextoDatosGuardar.DatabaseExists())
               {
                   
                   ContextoDatosGuardar.SubmitChanges();
                   MessageBox.Show("La lista ha sido guardada ");
               }
           }
       }

        // Desactivar Alarma
       private void BotonMute_Click(object sender, RoutedEventArgs e)
       {

           //  despues de 4 veces no funciona el cambio de color y ahi que presionar en otro lado para que funcione eso en expresion blend con los estados
           if (MediaElementAlarma.IsMuted == true)
           {
               MediaElementAlarma.IsMuted = false;
           }
           else
           {
               MediaElementAlarma.IsMuted = true;
           }


           
       }
        // Botón Pausa
       private void BotonPausa_Play_Click(object sender, RoutedEventArgs e)
       {
          MediaElementAlarma.Pause();

          

       }
        // Botón Stop
       private void BotonStop_Click(object sender, RoutedEventArgs e)
       {
           MediaElementAlarma.Stop();
       }

        // Botón Play
       private void BotonPlay_Click(object sender, RoutedEventArgs e)
       {
           MediaElementAlarma.Play();
           
       }

       

    
   
    
        
   

           
      

        
     
        

    }
}
