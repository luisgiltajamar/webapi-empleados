using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiEmpleados.Models.ViewModels
{
    public class CargoViewModel:IViewModel<Cargo>
    {
        public int idCargo { get; set; }
        public string nombre { get; set; }
        public decimal salarioBase { get; set; }


        public Cargo ToBaseDatos()
        {
            var model = new Cargo()
            {
                idCargo = idCargo,
                nombre = nombre,
                salarioBase = salarioBase

            };
            return model;
        }

        public void FromBaseDatos(Cargo model)
        {
            idCargo = model.idCargo;
            nombre = model.nombre;
            salarioBase = model.salarioBase;
        }

        public void UpdateBaseDatos(Cargo model)
        {
            model.idCargo = idCargo;
            model.nombre = nombre;
            model.salarioBase = salarioBase;
        }

        public int[] GetPk()
        {
            return new[] {idCargo};
        }
    }
}