using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiEmpleados.Models.ViewModels
{
    public class ProyectoView:IViewModel<Proyecto>
    {

        public int idProyecto { get; set; }
        public string nombre { get; set; }
        public string cliente { get; set; }
        public string descripcion { get; set; }

        public Proyecto ToBaseDatos()
        {
            var model = new Proyecto()
            {
                idProyecto = idProyecto,
                nombre = nombre,
                cliente = cliente,
                descripcion = descripcion

            };
            return model;
        }

        public void FromBaseDatos(Proyecto model)
        {
            idProyecto = model.idProyecto;
            nombre = model.nombre;
            cliente = model.cliente;
            descripcion = model.descripcion;
        }

        public void UpdateBaseDatos(Proyecto model)
        {
            model.idProyecto = idProyecto;
            model.nombre = nombre;
            model.cliente = cliente;
            model.descripcion = descripcion;
        }

        public int[] GetPk()
        {
            return new[] {idProyecto};
        }
    }
}