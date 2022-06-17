using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Provincia
    {
        private string NombreProvincia;
        private string IdProvincia;
        private string IdPais;

        public Provincia(string nombreProvincia, string idProvincia, string idPais)
        {
            NombreProvincia = nombreProvincia;
            IdProvincia = idProvincia;
            IdPais = idPais;
        }

        public Provincia()
        {

        }


        public string NombreDeLaProvincia
        {
            get => NombreProvincia;
            set => NombreProvincia = value;
        }

        public string IdDeLaProvincia
        {
            get => IdProvincia;
            set => IdProvincia = value;
        }

        public string IdDelPais
        {
            get => IdPais;
            set => IdPais = value;
        }
    }
}
