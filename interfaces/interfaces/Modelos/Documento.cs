using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Documento
    {
        private string carpeta;
        private string ordenCarpeta;
        private DateTime fecha;
        private string contenido;
        private string clave1;
        private string clave2;
        private string clave3;

        public Documento()
        {
        }

        public Documento(string carpeta, string ordenCarpeta, DateTime fecha, string contenido, string clave1, string clave2, string clave3)
        {
            this.Carpeta = carpeta;
            this.OrdenCarpeta = ordenCarpeta;
            this.Fecha = fecha;
            this.Contenido = contenido;
            this.Clave1 = clave1;
            this.Clave2 = clave2;
            this.Clave3 = clave3;
        }

        public string Carpeta { get => carpeta; set => carpeta = value; }
        public string OrdenCarpeta { get => ordenCarpeta; set => ordenCarpeta = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public string Clave1 { get => clave1; set => clave1 = value; }
        public string Clave2 { get => clave2; set => clave2 = value; }
        public string Clave3 { get => clave3; set => clave3 = value; }
    }
}
