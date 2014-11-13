using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiEmpleados.Models;
using WebApiEmpleados.Models.ViewModels;
using WebApiEmpleados.Repositorio;

namespace WebApiEmpleados.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProyectoController : ApiController
    {
       private readonly IRepositorio<ProyectoView,Proyecto> repo=
            new Repositorio<ProyectoView, Proyecto>(new rrhhEntities()); 
        // GET: api/Proyecto
        public IEnumerable<ProyectoView> Get()
        {
            return repo.Get();
        }

        // GET: api/Proyecto/5
        public ProyectoView Get(int args)
        {
            return repo.Get(args);
        }

        // POST: api/Proyecto
        public void Post([FromBody]ProyectoView value)
        {
            repo.Add(value);
        }

        // PUT: api/Proyecto/5
        public void Put([FromBody]ProyectoView value)
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
