using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiEmpleados.Models.ViewModels
{
    public class EmpleadoViewModel:IViewModel<Empleado>
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public int idCargo { get; set; }
        public Nullable<decimal> salario { get; set; }

        public String NombreCargo { get; set; }

        public List<ProyectoView> Proyectos { get; set; }

        public Empleado ToBaseDatos()
        {
            var model = new Empleado()
            {
                idEmpleado = idEmpleado,
                idCargo = idCargo,
                nombre = nombre,
                dni = dni,
                salario = salario

            };
            return model;
        }

        public void FromBaseDatos(Empleado model)
        {
            
                idEmpleado = model.idEmpleado;
                idCargo = model.idCargo;
                nombre = model.nombre;
                dni = model.dni;
                salario = model.salario;

           try
            { 
                NombreCargo = model.Cargo.nombre;

                Proyectos = model.Proyecto.Select(o=>new ProyectoView()
                {
                    idProyecto = o.idProyecto,
                    nombre = o.nombre
                }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void UpdateBaseDatos(Empleado model)
        {
            model.idEmpleado = idEmpleado;
            model.idCargo = idCargo;
            model.nombre = nombre;
            model.dni = dni;
            model.salario = salario;
        }

        public int[] GetPk()
        {
            return new[] {idEmpleado};
        }
    }
}