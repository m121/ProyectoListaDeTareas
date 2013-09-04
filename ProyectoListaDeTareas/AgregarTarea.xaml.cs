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
using Microsoft.Phone.Tasks;

namespace ProyectoListaDeTareas
{
   

    public partial class AgregarTarea : PhoneApplicationPage
    {
        // datos tarea 1
        string tarea1 = "";
        int hora1 = 0;
        int minuto1 = 0;
        int segundo1 = 0;
        
        // datos tarea 2
        string tarea2 = "";
        int hora2 = 0;
        int minuto2 = 0;
        int segundo2 = 0;

        // datos tarea 3
        string tarea3 = "";
        int hora3 = 0;
        int minuto3 = 0;
        int segundo3 = 0;

        // datos tarea 4
        string tarea4 = "";
        int hora4 = 0;
        int minuto4 = 0;
        int segundo4 = 0;

        // datos tarea 5
        string tarea5 = "";
        int hora5 = 0;
        int minuto5 = 0;
        int segundo5 = 0;

        // datos tarea 6
        string tarea6 = "";
        int hora6 = 0;
        int minuto6 = 0;
        int segundo6 = 0;

        // datos tarea 7
        string tarea7 = "";
        int hora7 = 0;
        int minuto7 = 0;
        int segundo7 = 0;

        // datos tarea 8
        string tarea8 = "";
        int hora8 = 0;
        int minuto8 = 0;
        int segundo8 = 0;
         
        // datos tarea 9
        string tarea9 = "";
        int hora9 = 0;
        int minuto9 = 0;
        int segundo9 = 0;

        // datos tarea 10
        string tarea10 = "";
        int hora10 = 0;
        int minuto10 = 0;
        int segundo10 = 0;

        // datos tarea 11
        string tarea11 = "";
        int hora11 = 0;
        int minuto11 = 0;
        int segundo11 = 0;

        // datos tarea 12
        string tarea12 = "";
        int hora12 = 0;
        int minuto12 = 0;
        int segundo12 = 0;

        public AgregarTarea()
        {
            InitializeComponent();


            
            
        }
         
        int i = 1;
        
       
      // boton crear base de datos e ir a otra pag
        private void BotonAgregar_Click(object sender, RoutedEventArgs e)
        {
            using (BaseListasDataContext dataContext = new BaseListasDataContext("Data source='isostore:/ListasDB.sdf'"))
            {
                if (!dataContext.DatabaseExists())
                {
                 //   dataContext.DeleteDatabase();
                    dataContext.CreateDatabase();

                    List<Lista> listaobj = new List<Lista>()
                    {
                       
                        new Lista()
                        {
                            Id = 1 , Tarea = tarea1  , Hora = hora1 , Minuto = minuto1 , Segundo = segundo1
                        } ,
                        

                        new Lista()
                        {
                            Id = 2 , Tarea = tarea2 , Hora = hora2 , Minuto = minuto2 , Segundo = segundo2
                        } ,

                        new Lista()
                        {
                            Id = 3 , Tarea = tarea3 , Hora = hora3 , Minuto = minuto3 , Segundo = segundo3
                        } ,

                        new Lista()
                        {
                            Id = 4 , Tarea = tarea4 , Hora = hora4 , Minuto = minuto4 , Segundo = segundo4
                        } ,

                        new Lista()
                        {
                            Id = 5 , Tarea = tarea5 , Hora = hora5 , Minuto = minuto5 , Segundo = segundo5
                        } ,

                        new Lista()
                        {
                            Id = 6 , Tarea = tarea6 , Hora = hora6 , Minuto = minuto6 , Segundo = segundo6
                        } ,

                        new Lista()
                        {
                            Id = 7 , Tarea = tarea7 , Hora = hora7 , Minuto = minuto7 , Segundo = segundo7
                        } ,

                        new Lista()
                        {
                            Id = 8 , Tarea = tarea8 , Hora = hora8 , Minuto = minuto8 , Segundo = segundo8
                        } ,

                        new Lista()
                        {
                            Id = 9 , Tarea = tarea9 , Hora = hora9 , Minuto = minuto9 , Segundo = segundo9
                        } ,

                        new Lista()
                        {
                            Id = 10 , Tarea = tarea10 , Hora = hora10 , Minuto = minuto10 , Segundo = segundo10
                        } ,

                        new Lista()
                        {
                            Id = 11 , Tarea = tarea11 , Hora = hora11 , Minuto = minuto11 , Segundo = segundo11
                        } ,

                        new Lista()
                        {
                            Id = 12 , Tarea = tarea12 , Hora = hora12 , Minuto = minuto12 , Segundo = segundo12
                        } 

                    };

                    dataContext.Lista.InsertAllOnSubmit(listaobj);
                    dataContext.SubmitChanges();
                    
                }
            }
       
      
            NavigationService.Navigate(new Uri("/Dia1.xaml",UriKind.Relative));
            i = 1;
            NumeroDeTarea.Text =Convert.ToString( i);
        }

       
        // boton guardar las tareas
        private void BotonGuardar_Click(object sender, RoutedEventArgs e)
        {
           
            

            try
            {

                //guardar tarea 1

                if (i == 1)
                {

                    tarea1 = textBox1.Text;
                    if (tarea1 == "Tu primera tarea")
                    {
                        MessageBox.Show("¡Necesitas mínimo una tarea!");
                        i = 0;
                    }
                    hora1 = Convert.ToInt32(TextoHoras.Text);
                    minuto1 = Convert.ToInt32(TextoMinutos.Text);
                    segundo1 = Convert.ToInt32(TextoSegundos.Text);
              // Agrega almenos 10 segundos a cada tarea si no se agrega ningun tiempo
                    if ((hora1 == 0) && (minuto1 == 0) && (segundo1 == 0))
                    {
                        segundo1 = 10;
                    }



                }

                //guardar tarea 2

                if (i == 2)
                {


                    tarea2 = textBox1.Text;
                    hora2 = Convert.ToInt32(TextoHoras.Text);
                    minuto2 = Convert.ToInt32(TextoMinutos.Text);
                    segundo2 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora2 == 0) && (minuto2 == 0) && (segundo2 == 0))
                    {
                        segundo2 = 10;
                    }
                }

                //guardar tarea 3

                if (i == 3)
                {
                    tarea3 = textBox1.Text;
                    hora3 = Convert.ToInt32(TextoHoras.Text);
                    minuto3 = Convert.ToInt32(TextoMinutos.Text);
                    segundo3 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora3 == 0) && (minuto3 == 0) && (segundo3== 0))
                    {
                        segundo3 = 10;
                    }
                }

                //guardar tarea 4

                if (i == 4)
                {
                    tarea4 = textBox1.Text;
                    hora4 = Convert.ToInt32(TextoHoras.Text);
                    minuto4 = Convert.ToInt32(TextoMinutos.Text);
                    segundo4 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora4 == 0) && (minuto4 == 0) && (segundo4 == 0))
                    {
                        segundo4 = 10;
                    }
                }

                //guardar tarea 5

                if (i == 5)
                {
                    tarea5 = textBox1.Text;
                    hora5 = Convert.ToInt32(TextoHoras.Text);
                    minuto5 = Convert.ToInt32(TextoMinutos.Text);
                    segundo5 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora5 == 0) && (minuto5 == 0) && (segundo5 == 0))
                    {
                        segundo5 = 10;
                    }
                }

                //guardar tarea 6

                if (i == 6)
                {
                    tarea6 = textBox1.Text;
                    hora6 = Convert.ToInt32(TextoHoras.Text);
                    minuto6 = Convert.ToInt32(TextoMinutos.Text);
                    segundo6 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora6 == 0) && (minuto6 == 0) && (segundo6 == 0))
                    {
                        segundo6 = 10;
                    }
                }

                //guardar tarea 7

                if (i == 7)
                {
                    tarea7 = textBox1.Text;
                    hora7 = Convert.ToInt32(TextoHoras.Text);
                    minuto7 = Convert.ToInt32(TextoMinutos.Text);
                    segundo7 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora7 == 0) && (minuto7 == 0) && (segundo7 == 0))
                    {
                        segundo7 = 10;
                    }
                }

                //guardar tarea 8

                if (i == 8)
                {
                    tarea8 = textBox1.Text;
                    hora8 = Convert.ToInt32(TextoHoras.Text);
                    minuto8 = Convert.ToInt32(TextoMinutos.Text);
                    segundo8 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora8 == 0) && (minuto8 == 0) && (segundo8 == 0))
                    {
                        segundo8 = 10;
                    }
                }

                //guardar tarea 9

                if (i == 9)
                {
                    tarea9 = textBox1.Text;
                    hora9 = Convert.ToInt32(TextoHoras.Text);
                    minuto9 = Convert.ToInt32(TextoMinutos.Text);
                    segundo9 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora9 == 0) && (minuto9 == 0) && (segundo9 == 0))
                    {
                        segundo9 = 10;
                    }
                }

                //guardar tarea 10

                if (i == 10)
                {
                    tarea10 = textBox1.Text;
                    hora10 = Convert.ToInt32(TextoHoras.Text);
                    minuto10 = Convert.ToInt32(TextoMinutos.Text);
                    segundo10 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora10 == 0) && (minuto10 == 0) && (segundo10 == 0))
                    {
                        segundo10 = 10;
                    }
                }

                //guardar tarea 11

                if (i == 11)
                {
                    tarea11 = textBox1.Text;
                    hora11 = Convert.ToInt32(TextoHoras.Text);
                    minuto11 = Convert.ToInt32(TextoMinutos.Text);
                    segundo11 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora11 == 0) && (minuto11 == 0) && (segundo11 == 0))
                    {
                        segundo11 = 10;
                    }
                }

                //guardar tarea 12

                if (i == 12)
                {
                    tarea12 = textBox1.Text;
                    hora12 = Convert.ToInt32(TextoHoras.Text);
                    minuto12 = Convert.ToInt32(TextoMinutos.Text);
                    segundo12 = Convert.ToInt32(TextoSegundos.Text);

                    if ((hora12 == 0) && (minuto12 == 0) && (segundo12 == 0))
                    {
                        segundo12 = 10;
                    }
                }




                textBox1.Text = "";
                TextoHoras.Text = "00";
                TextoMinutos.Text = "00";
                TextoSegundos.Text = "00";
                // si i es menor que 13 suma si es igual o mayor no puede ya que solo se puede 12 tareas
                if (i < 13)
                {
                    i++;
                }
                else
                {
                    MessageBox.Show("¡Solo puedes agregar hasta 12 tareas!");
                   
                }
                NumeroDeTarea.Text = Convert.ToString(i);



            }
            catch (FormatException)
            {
                MessageBox.Show("! Debes ingresar al menos un número en el crónometro , si lo deseas lo puedes dejar en 00 ! ");
            }

        

                
            
        }

       

        // botón atrás
        private void BotonAtras_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

       
        
        

       
    }
}


