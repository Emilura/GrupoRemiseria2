﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Datos
{
    internal class Funcion
    {
        class Funciones
        {

            public static void logs(string nombre_archivo, string detalle)
            {
                string directorio = AppDomain.CurrentDomain.BaseDirectory + "logs/" +
                    DateTime.Now.Year.ToString() + "/" +
                DateTime.Now.Month.ToString() + "/" +
                DateTime.Now.Day.ToString() + "/";

                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }
                StreamWriter mi_archivo = new StreamWriter(directorio + "/" + nombre_archivo + ".txt", true);
                string descripcion = DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss") + "->" + detalle;
                mi_archivo.WriteLine(descripcion);
                mi_archivo.Close();
            }


        }
    }
}
