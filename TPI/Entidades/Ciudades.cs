using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Ciudad
    {
        private int Id;
        private string Nombre;
        private int IdProvincia;


        public Ciudad()
        {
        }
        public Ciudad(int id, string nombre, int idProvincia)
        {
            Id = id;
            Nombre = nombre;
            IdProvincia = idProvincia;
        }

        public int IdCiudad
        {
            get => Id;
            set => Id = value;
        }

        public string NombreCiudad
        {
            get => Nombre;
            set => Nombre = value;
        }

        public int IdProvinciaCiudad
        {
            get => IdProvincia;
            set => IdProvincia = value;
        }
    }
}
