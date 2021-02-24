using CarCenterApp.Models;
using CarCenterApp.Models.Request;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CarCenterApp.Controllers
{
    public class ClientesController : ApiController
    {
        //Agregar Cliente
        [HttpPost]
        public IHttpActionResult AgregarCliente(ClienteRequest model)
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
        //Consultar Clientes
        [HttpGet]
        public IEnumerable<ClienteRequest> ListarClientes()
        {
            using (Models.CarCenterDB db = new Models.CarCenterDB())
            {
                var clientes = db.Clientes.Select(x => new ClienteRequest
                {
                    PrimerNombre = x.PrimerNombre,
                    SegundoNombre = x.SegundoNombre,
                    PrimerApellido = x.PrimerApellido,
                    SegundoApellido = x.SegundoApellido,
                    TipoDocumento = x.TipoDocumento,
                    NumeroDocumento = x.NumeroDocumento,
                    NumeroCelular = x.NumeroCelular,
                    Direccion = x.Direccion,
                    CorreoElectronico = x.CorreoElectronico,
                    Presupuesto = x.Presupuesto

                }).ToList();
                return clientes;
            }
        }
        [HttpPost]
        public IHttpActionResult EliminarCliente(int id)
        {
            if (id < 0)
            { 
                return BadRequest("Cliente no válido");
            }
            using (var db = new CarCenterDB())
            {
                var cliente = db.Clientes
                    .Where(s => s.idCliente == id)
                    .FirstOrDefault();

                db.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }

            return Ok();
        }

        public IHttpActionResult ActualizarCliente(ClienteRequest cliente)
        {
            if (!ModelState.IsValid)
                return BadRequest("No es un cliente válido");

            using (var db = new CarCenterDB())
            {
                var clienteExistente = db.Clientes.Where(s => s.idCliente == cliente.idCliente)
                                                        .FirstOrDefault<Clientes>();

                if (clienteExistente != null)
                {
                    clienteExistente.PrimerNombre = cliente.PrimerNombre;
                    clienteExistente.SegundoNombre = cliente.SegundoNombre;
                    clienteExistente.PrimerApellido = cliente.PrimerApellido;
                    clienteExistente.SegundoApellido = cliente.SegundoApellido;
                    clienteExistente.TipoDocumento = cliente.TipoDocumento;
                    clienteExistente.NumeroDocumento = cliente.NumeroDocumento;
                    clienteExistente.NumeroCelular = cliente.NumeroCelular;
                    clienteExistente.Direccion = cliente.Direccion;
                    clienteExistente.CorreoElectronico = cliente.CorreoElectronico;
                    clienteExistente.Presupuesto = cliente.Presupuesto;
                    db.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }

    }
}
