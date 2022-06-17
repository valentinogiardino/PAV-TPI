using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Empleado
    {
        
        private string NroDoc;
        private int TipoDoc;
        private string Legajo;
        private string Cuil;
        private string Apellido;
        private string Nombre;
        private string Calle;
        private string NroCalle;
        private int IdCiudad;
        private DateTime FechaIngreso;
        private bool Gerente;

        public Empleado(string legajo, string nroDocumento)
        {
            Legajo = legajo;
            NroDoc = nroDocumento;
        }

        public Empleado()
        {

        }

        public string NroDocumentoEmpleado
        {
            get => NroDoc;
            set => NroDoc = value;
        }

        public int TipoDocEmpleado
        {
            get => TipoDoc;
            set => TipoDoc = value;
        }
        public string LegajoDeEmpleado
        {
            get => Legajo;
            set => Legajo = value;
        }

        public string CuilEmpleado
        {
            get => Cuil;
            set => Cuil = value;
        }

        public string ApellidoEmpleado
        {
            get => Apellido;
            set => Apellido = value;
        }

        public string NombreEmpleado
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string CalleEmpleado
        {
            get => Calle;
            set => Calle = value;
        }

        public string NroCalleEmpleado
        {
            get => NroCalle;
            set => NroCalle = value;
        }

        public int IdCiudadEmpleado
        {
            get => IdCiudad;
            set => IdCiudad = value;
        }

        public DateTime FechaIngresoEmpleado
        {
            get => FechaIngreso;
            set => FechaIngreso = value;
        }

        public bool GerenteEmpleado
        {
            get => Gerente;
            set => Gerente = value;
        }



    }
}
