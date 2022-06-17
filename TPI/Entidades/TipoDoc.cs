using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    class TipoDoc
    {
        private int IdTipoDoc;
        private string NombreTipoDoc;

        public TipoDoc(int idTipoDoc, string nombreTipoDoc)
        {
            IdTipoDoc = idTipoDoc;
            NombreTipoDoc = nombreTipoDoc;
        }

        public TipoDoc()
        {

        }

        public int IdTipoDeDoc
        {
            get => IdTipoDoc;
            set => IdTipoDoc = value;
        }

        public string NombreTipoDeDoc
        {
            get => NombreTipoDoc;
            set => NombreTipoDoc = value;
        }

    }
}
