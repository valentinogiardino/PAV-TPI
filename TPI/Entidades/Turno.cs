using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Turno
    {
        private string CuitEstacion;
        private string NombreTurno;
        private string Descripcion;
        private string HoraDesde;
        private string HoraHasta;

        public Turno(string cuitEstacion, string nombreTurno, string descripcion)
        {
            CuitEstacion = cuitEstacion;
            NombreTurno = nombreTurno;
            Descripcion = descripcion;
        }

        public Turno()
        {

        }


        public string CuitDeLaEstacion
        {
            get => CuitEstacion;
            set => CuitEstacion = value;
        }

        public string NombreDelTurno
        {
            get => NombreTurno;
            set => NombreTurno = value;
        }

        public string DescripcionDelTurno
        {
            get => Descripcion;
            set => Descripcion = value;
        }

        public string HoraDesdeTurno
        {
            get => HoraDesde;
            set => HoraDesde = value;
        }
        public string HoraHastaTurno
        {
            get => HoraHasta;
            set => HoraHasta = value;
        }

    }
}
