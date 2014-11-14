using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApiEmpleados.Utilidades
{
    public class Logs
    {
        private static String ruta = @"c:\temp\logs\log-webapi.txt";

        public static bool ComprobarLog()
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    File.Create(ruta).Close();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public static void LogError(String txt)
        {
            var f = DateTime.Now;

            if (ComprobarLog())
            {
                String msg = String.Format("{0:g}->{1}", f, txt);
                File.AppendAllText(ruta,msg);
            }

        }
        public static void LogError(Exception ex)
        {
            //var f = DateTime.Now;

            //if (ComprobarLog())
            //{
            //    String msg = String.Format("{0:g}->{1}", f, ex.StackTrace);
            //    File.AppendAllText(ruta, msg);
            //}

            LogError(ex.StackTrace);
        }
    }
}