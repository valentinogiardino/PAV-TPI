using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Tanque
    {
        private int NumTanque;
        private string CuitEstacion;
        private float VolMax;
        private float MinLit;
        private int IdCombustible;
        private float VolDisponible;


        public Tanque(int numTanque, string cuitEstacion)
        {
            NumTanque = numTanque;
            CuitEstacion = cuitEstacion;
        }

        public Tanque()
        {

        }

        public int NumDeTanque
        {
            get => NumTanque;
            set => NumTanque = value;
        }

        public string CuitEstacionTanque
        {
            get => CuitEstacion;
            set => CuitEstacion = value;
        }

        public float VolMaxCombustible
        {
            get => VolMax;
            set =>VolMax = value;
        }

        public float MinLitTanque
        {
            get => MinLit;
            set => MinLit = value;
        }

        public int IdCombustibleTanque
        {
            get => IdCombustible;
            set => IdCombustible = value;
        }

        public float VolDisponibleTanque
        {
            get => VolDisponible;
            set => VolDisponible = value;
        }
    }
}

