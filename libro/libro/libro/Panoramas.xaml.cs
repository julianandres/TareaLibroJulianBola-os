using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;

namespace libro
{
    public partial class Panoramas : PhoneApplicationPage
    {
        public Panoramas()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (NavigationContext.QueryString.ContainsKey("id"))
            {
                String dato1 = NavigationContext.QueryString["id"];
                if (dato1.Equals("1"))
                {
                    llenarDatos(0);
                }
                else {
                    if (dato1.Equals("2"))
                    {
                        llenarDatos(1);                     
                    }
                    else
                    {
                        llenarDatos(2);
                    }
                
                }
            }            
        }
        private void llenarDatos(int id) {
            String fuentePortada="";
            String fuenteContPortada = "";
            String fuenteOtra = "";
           var libro = LayoutRoot.Resources["dat"] as Models.libros;
                        if(libro!=null){
                            codigo.Text =  libro.Data[id].Codigo;
                            genero.Text =  libro.Data[id].Genero;
                            autor.Text =   libro.Data[id].Autor;
                            nombre.Text = libro.Data[id].Nombre;
                            paginas.Text = ""+libro.Data[id].Paginas;
                        }
                        if (id == 0) {
                            fuenteContPortada = "Resources/contPort1.png";
                            fuentePortada = "Resources/portada1.png";
                            fuenteOtra = "Resources/otra1.png";
                        }
                        if (id == 1)
                        {
                            fuenteContPortada = "Resources/contPort2.png";
                            fuentePortada = "Resources/portada2.png";
                            fuenteOtra = "Resources/otra2.png";

                        }
                        if (id == 2)
                        {
                            fuenteContPortada = "Resources/contPort3.png";
                            fuentePortada = "Resources/portada3.png";
                            fuenteOtra = "Resources/otra1.png";

                        }
                        BitmapImage port =
                        new BitmapImage(new Uri(fuentePortada, UriKind.Relative));
                        portada.Source = port;
                        BitmapImage contPort =
                                    new BitmapImage(new Uri(fuenteContPortada, UriKind.Relative));
                        contPortada.Source = contPort;
                        BitmapImage other =
                                    new BitmapImage(new Uri(fuenteOtra, UriKind.Relative));
                        adicional.Source = other;
        
        }
    }
}