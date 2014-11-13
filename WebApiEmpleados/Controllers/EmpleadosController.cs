using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiEmpleados.Models;
using WebApiEmpleados.Models.ViewModels;
using WebApiEmpleados.Repositorio;

namespace WebApiEmpleados.Controllers
{
    [EnableCors("*", "*", "*")]
    public class EmpleadosController : ApiController
    {
        RepositorioEmpleados repo =
            new RepositorioEmpleados(new rrhhEntities()); 
        // GET: api/Empleados
        public IEnumerable<EmpleadoViewModel> Get()
        {
            return repo.Get();
        }

        // GET: api/Empleados/5
        [HttpGet]
        public EmpleadoViewModel PorId(int args)
        {
            var datos = repo.Get(args);
            return datos;
        }
        [HttpGet]
        public List<EmpleadoViewModel> PorSalario(decimal args)
        {
            var datos = repo.GetBySalario(args);
            return datos;
        }
        [HttpGet]
        public List<EmpleadoViewModel> PorNombre(String args)
        {
            var datos = repo.GetByNombre(args);
            return datos;
        }
        [HttpGet]
        public List<EmpleadoViewModel> PorCargo(String args)
        {
            var datos = repo.GetByCargo(args);
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
