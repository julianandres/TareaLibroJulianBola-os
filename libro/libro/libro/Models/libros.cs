using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace libro.Models
{
    public class libros
    {
        private ObservableCollection<Libro> data;

        public ObservableCollection<Libro> Data {
            get
            {
                if (data == null)
                {
                    data = new ObservableCollection<Libro>();
                    Libro libro1 = new Libro()
                    {
                        Indice=1,
                        Nombre = "Angeles y demonios",
                        Autor = "Dan Brown",
                        Codigo = "123",
                        Genero = "Intriga y Suspenso",
                        Paginas = 606
                    };
                    Libro libro2 = new Libro()
                   {
                       Indice=2,
                       Nombre = "Codigo Da vinci",
                       Autor = "Brown",
                       Codigo = "1236",
                       Genero = "Aventura",
                       Paginas = 1599
                   };
                    Libro libro3 = new Libro()
                   {   Indice=3, 
                       Nombre = "Orgullo y prejuicio",
                       Autor = "jane austen",
                       Codigo = "1237",
                       Genero = "Romance",
                       Paginas = 1569
                   };

                    data.Add(libro1);
                    data.Add(libro2);
                    data.Add(libro3);
                }
                
                return data;
            }
            set 
            {
 
            }
        
        }

    }
}
