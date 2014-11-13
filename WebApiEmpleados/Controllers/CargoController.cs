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
    public class CargoController : ApiController
    {
        private readonly IRepositorio<CargoViewModel, Cargo> repo =
             new Repositorio<CargoViewModel, Cargo>(new rrhhEntities());
        // GET: api/Proyecto
        public IEnumerable<CargoViewModel> Get()
        {
            return repo.Get();
        }

        // GET: api/Proyecto/5
        public CargoViewModel Get(int args)
        {
            return repo.Get(args);
        }

        // POST: api/Proyecto
        public void Post([FromBody]CargoViewModel value)
        {
            repo.Add(value);
        }

        // PUT: api/Proyecto/5
        public void Put([FromBody]CargoViewModel value)
        {
            repo.Actualizar(value);
        }

        // DELETE: api/Proyecto/5
        public void Delete(int args)
        {
            repo.Borrar(args);
        }
    }
}
