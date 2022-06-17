using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    class TipoCombustible
    {
        private int IdTipoCombustible;
        private string NombreTipoCombustible;

        public TipoCombustible(int idTipoCombustible, string nombreTipoCombustible)
        {
            IdTipoCombustible = idTipoCombustible;
            NombreTipoCombustible = nombreTipoCombustible;
        }

        public TipoCombustible()
        {

        }

        public int IdTipoDeCombustible
        {
            get => IdTipoCombustible;
            set => IdTipoCombustible = value;
        }

        public string NombreTipoDeCombustible
        {
            get => NombreTipoCombustible;
            set => NombreTipoCombustible = value;
        }
    }
}
