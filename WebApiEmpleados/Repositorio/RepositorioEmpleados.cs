using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using WebApiEmpleados.Models;
using WebApiEmpleados.Models.ViewModels;

namespace WebApiEmpleados.Repositorio
{
    
    public class RepositorioEmpleados:Repositorio<EmpleadoViewModel,Empleado>
    {
        public RepositorioEmpleados(rrhhEntities context) : base(context)
        {
        }

        public override EmpleadoViewModel Add(EmpleadoViewModel modelo)
        {
            var ipProyecto = modelo.Proyectos.Select(o => o.idProyecto).ToArray();

            var proyectos = Context.Proyecto.Where(o => ipProyecto.Contains(o.idProyecto));

            var obj = modelo.ToBaseDatos();
            obj.Proyecto = proyectos.ToList();
            Context.Empleado.Add(obj);
            Context.SaveChanges();

            modelo.FromBaseDatos(obj);

            return modelo;

        }

        public List<EmpleadoViewModel> GetByNombre(String nombre)
        {
            return Get(o => o.nombre.Contains(nombre));
        }

        public List<EmpleadoViewModel> GetByCargo(String nombre)
        {
            return Get(o => o.Cargo.nombre.Contains(nombre));
        }

        public List<EmpleadoViewModel> GetBySalario(decimal valor)
        {
            return Get(o => o.salario.HasValue && o.salario.Value >= valor);
        }
    }
}