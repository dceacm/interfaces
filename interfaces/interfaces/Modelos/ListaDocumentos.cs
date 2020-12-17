using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Modelos
{
    public class ListaDocumentos
    {
        private List<Documento> lista_documentos = new List<Documento>();

        public List<Documento> Lista_documentos { get => lista_documentos; set => lista_documentos = value; }
    }
}
