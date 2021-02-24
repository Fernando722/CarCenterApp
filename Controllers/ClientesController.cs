using System.Web.Http;

namespace CarCenterApp.Controllers
{
    public class ClientesController : ApiController
    {
        [HttpPost]
        public IHttpActionResult AgregarCliente(Models.Request.ClienteRequest model) 
        {
            using (Models.CarCenterDB db = new Models.CarCenterDB())
            {
                var oCliente = new Models.Clientes();
                oCliente.PrimerNombre = model.PrimerNombre;
                oCliente.SegundoNombre = model.SegundoNombre;
                oCliente.PrimerApellido = model.PrimerApellido;
                oCliente.SegundoApellido = model.SegundoApellido;
                oCliente.TipoDocumento = model.TipoDocumento;
                oCliente.NumeroDocumento = model.NumeroDocumento;
                oCliente.NumeroCelular = model.NumeroCelular;
                oCliente.Direccion = model.Direccion;
                oCliente.CorreoElectronico = model.CorreoElectronico;
                oCliente.Presupuesto = model.Presupuesto;
                db.Clientes.Add(oCliente);
                db.SaveChanges();
            }
            return Ok("Cliente agregado satisfactoriamente");
        }
    }
}
