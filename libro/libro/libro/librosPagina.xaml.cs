using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using libro.Models;



namespace libro
{
    public partial class librosPagina : PhoneApplicationPage
    {

        public librosPagina()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void goToPage(object sender, SelectionChangedEventArgs e)
        {
            
            
            var selectedItem = list.SelectedItem as Libro;
            
            
           /* if (selectedItem == "")
            {
                NavigationService.Navigate(
                    new Uri("/Panorama.xaml?dato1=saludos", UriKind.Relative)
                    );
            }
            else
            {
                NavigationService.Navigate(
                    new Uri("/Pivot.xaml?dato2=Hola", UriKind.Relative)
                    );

            }
            */
            NavigationService.Navigate(
                    new Uri("/Libros.xaml?nombre="+selectedItem.Nombre+"&autor="+selectedItem.Autor
                        +"&codigo="+selectedItem.Codigo+"&paginas="+selectedItem.Paginas+"&genero="+selectedItem.Genero+"&indice="+selectedItem.Indice, UriKind.Relative)
                    );
        }

        
    }

}