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


        public Proyecto ToBaseDatos()
        {
            var model = new Proyecto()
            {
                idProyecto = idProyecto,
                nombre = nombre

            };
            return model;
        }

        public void FromBaseDatos(Proyecto model)
        {
            idProyecto = model.idProyecto;
            nombre = model.nombre;
        }

        public void UpdateBaseDatos(Proyecto model)
        {
            model.idProyecto = idProyecto;
            model.nombre = nombre;
        }

        public int[] GetPk()
        {
            return new[] {idProyecto};
        }
    }
}