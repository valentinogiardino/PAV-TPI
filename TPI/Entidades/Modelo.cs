using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Modelo
    {
      
        private string NombreModelo;
        private int IdMarca;
        private int IdModelo;
        



        public Modelo(string nombreModelo)
        {
            NombreModelo = nombreModelo;
        }

        public Modelo()
        {

        }
      
        

        public string NombreDelModelo
        {
            get => NombreModelo;
            set => NombreModelo = value;
        }

        public int IdDeMarca
        {
            get => IdMarca;
            set => IdMarca = value;
        }
        public int IdDeModelo
        {
            get => IdModelo;
            set => IdModelo = value;
        }


    }
}

