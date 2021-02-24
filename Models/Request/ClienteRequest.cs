using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarCenterApp.Models.Request
{
    public class ClienteRequest
    {
        public int idCliente { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NumeroCelular { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public Nullable<int> Presupuesto { get; set; }
    }
}