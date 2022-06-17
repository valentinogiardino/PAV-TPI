using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Estacion
    {
        private string NroCuit;
        private int NumSuc;
        private string NomSuc;
        private string CalleSuc;
        private string NroCalle;
        private int idCiudad;
        private string NroDocGerente;
        private int idTipoDocGerente;

        public Estacion(string cuit, string nomSuc)
        {
            NroCuit = cuit;
            NombreSucursal = nomSuc;
        }

        public Estacion()
        {

        }

        public string NroCuitSuc
        {
            get => NroCuit;
            set => NroCuit = value;
        }

        public int NumSucursal
        {
            get => NumSuc;
            set => NumSuc = value;
        }

        public string NombreSucursal
        {
            get => NomSuc;
            set => NomSuc = value;
        }

        public string CalleSucursal
        {
            get => CalleSuc;
            set => CalleSuc = value;
        }

        public string NumeroCalleSucursal
        {
            get => NroCalle;
            set => NroCalle = value;
        }

        public int CiudadSucursal
        {
            get => idCiudad;
            set => idCiudad = value;
        }

        public string NroDocGerenteEstacion
        {
            get => NroDocGerente;
            set => NroDocGerente = value;
        }

        public int TipoDocGerenteEstacion
        {
            get => idTipoDocGerente;
            set => idTipoDocGerente = value;
        }
    }





}