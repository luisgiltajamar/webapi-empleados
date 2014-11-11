namespace WebApiEmpleados.Models.ViewModels
{
   public interface IViewModel<TModelo> where TModelo:class
   {

       TModelo ToBaseDatos();
       void FromBaseDatos(TModelo model);
       void UpdateBaseDatos(TModelo model);
       int[] GetPk();

   }
}
