using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Combustible
    {
        private int IdCombustible;
        private int CodTipoCombustible;
        private string Nombre;
        private float PrecioUnitario;


        public Combustible(int idCombustible)
        {
            IdCombustible = idCombustible;
        }

        public Combustible()
        {

        }

        public int IdDeCombustible
        {
            get => IdCombustible;
            set => IdCombustible = value;
        }

        public int CodTipoDeCombustible
        {
            get => CodTipoCombustible;
            set => CodTipoCombustible = value;
        }

        public string NombreDeCombustible
        {
            get => Nombre;
            set => Nombre = value;
        }

        public float PrecioUnitarioDeCombustible
        {
            get => PrecioUnitario;
            set => PrecioUnitario = value;
        }
    }
}
