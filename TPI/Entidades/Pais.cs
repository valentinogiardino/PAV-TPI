using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Pais
    {
        private string NombrePais;
        private string IdPais;

        public Pais(string nombrePais, string idPais)
        {
            NombrePais = nombrePais;
            IdPais = idPais;
        }

        public Pais()
        {

        }


        public string NombreDelPais
        {
            get => NombrePais;
            set => NombrePais = value;
        }

        public string IdDelPais
        {
            get => IdPais;
            set => IdPais = value;
        }
    }
}
