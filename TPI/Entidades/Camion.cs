using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Camion
    {
        private string Patente;
        private int IdModelo;
        private float CantCombustibleMax;


        public Camion()
        {
        }
        public Camion(string patente, int idModelo, float cantCombustibleMax)
        {
            Patente = patente;
            IdModelo = idModelo;
            CantCombustibleMax = cantCombustibleMax;
        }

        public string PatenteCamion
        {
            get => Patente;
            set => Patente = value;
        }

        public int IdModeloCamion
        {
            get => IdModelo;
            set => IdModelo = value;
        }

        public float CantCombustibleMaxCamion
        {
            get => CantCombustibleMax;
            set => CantCombustibleMax = value;
        }
    }
}
