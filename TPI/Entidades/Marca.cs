using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Marca
    {

            private string NombreMarca;
            private int IdMarca;
            




            public Marca(string nombreMarca)
            {
                NombreMarca = nombreMarca;
            }

            public Marca()
            {

            }



            public string NombreDeMarca
            {
                get => NombreMarca;
                set => NombreMarca = value;
            }

            public int IdDeMarca
            {
                get => IdMarca;
                set => IdMarca = value;
            }


        
    }
}
