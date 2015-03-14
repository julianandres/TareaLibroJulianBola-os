using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;



namespace libro
{
    public partial class Libros : PhoneApplicationPage
    {
        public String id;
        public Libros()
        {
            InitializeComponent();
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            if (NavigationContext.QueryString.ContainsKey("nombre"))
            {
                String dato1 = NavigationContext.QueryString["nombre"];
                nombre.Text = dato1;
            }
           
            if (NavigationContext.QueryString.ContainsKey("paginas"))
            {
                String dato1 = NavigationContext.QueryString["paginas"];
                paginas.Text = dato1;
            }
            
            if (NavigationContext.QueryString.ContainsKey("codigo"))
            {
                String dato1 = NavigationContext.QueryString["codigo"];
                codigo.Text = dato1;
            }
           
            if (NavigationContext.QueryString.ContainsKey("autor"))
            {
                String dato1 = NavigationContext.QueryString["autor"];
                autor.Text = dato1;
            }
           
            if (NavigationContext.QueryString.ContainsKey("genero"))
            {
                String dato1 = NavigationContext.QueryString["genero"];
                genero.Text = dato1;
            }
            id ="";
            if (NavigationContext.QueryString.ContainsKey("indice"))
            {
                String dato1 = NavigationContext.QueryString["indice"];
                id = dato1;
            }
            
        }

        private void verImg(object sender, RoutedEventArgs e)
        {
             NavigationService.Navigate(
                        new Uri("/Panoramas.xaml?id="+id, UriKind.Relative)
                        );
        }
       
    }
}