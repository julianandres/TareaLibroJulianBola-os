using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libro.Models
{
        public class Libro : System.ComponentModel.INotifyPropertyChanged
        {
            private String nombre;
            public String Nombre
            {
                get { return nombre; }
                set
                {
                    nombre = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Nombre"));
                }
            }

            private String codigo;
            public String Codigo
            {
                get { return codigo; }
                set
                {
                    codigo = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Codigo"));
                }
            }

            private String autor;
            public String Autor
            {
                get { return autor; }
                set
                {
                    autor = value; if (PropertyChanged != null)
                        PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Autor"));
                }
            }
            private String genero;
            public String Genero
            {
                get { return genero; }
                set
                {
                    genero = value; if (PropertyChanged != null)
                        PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Genero"));
                }
            }

            private int paginas;
            public int Paginas
            {
                get { return paginas; }
                set
                {
                    paginas = value; if (PropertyChanged != null)
                        PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Paginas"));
                }
            }
            private int indice;
            public int Indice
            {
                get { return indice; }
                set
                {
                    indice = value
                        ; if (PropertyChanged != null)
                        PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs("Indice"));
                }
            }


            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        }
}
