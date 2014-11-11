using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiEmpleados.Models;
using WebApiEmpleados.Models.ViewModels;
using WebApiEmpleados.Repositorio;

namespace WebApiEmpleados.Controllers
{
    public class EmpleadosController : ApiController
    {
        IRepositorio<EmpleadoViewModel,Empleado> repo =
            new RepositorioEmpleados(new rrhhEntities()); 
        // GET: api/Empleados
        public IEnumerable<EmpleadoViewModel> Get()
        {
            return repo.Get();
        }

        // GET: api/Empleados/5
        public EmpleadoViewModel Get(int id)
        {
            var datos = repo.Get(o => o.idEmpleado == id).First();
            return datos;
        }

        // POST: api/Empleados
        public void Post([FromBody]EmpleadoViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Empleados/5
        public void Put([FromBody]EmpleadoViewModel value)
        {
            repo.Actualizar(value);
        }

        // DELETE: api/Empleados/5
        public void Delete(int id)
        {
            repo.Borrar(id);
        }
    }
}
