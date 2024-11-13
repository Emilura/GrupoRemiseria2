using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2.Datos
{
    internal class Conexion
    {

        class Conexiones
        {

            private readonly string bd = "dbremiseria";
            private readonly string servidor = "127.0.0.1";
            private readonly string puerto = "3306";
            private readonly string usuario = "root";
            private readonly string password = "";
            private string cadenaConexion;
            private MySqlConnection conn = null;



            public Conexiones()
            {
                cadenaConexion = "server=" + servidor + ";Database=" + bd + ";Uid=" + usuario + ";Pwd=" + password + ";";

            }
            public MySqlConnection crearConexion()
            {
                try
                {

                    if (conn == null)
                    {
                        conn = new MySqlConnection(cadenaConexion);

                    }

                }
                catch (Exception error)
                {

                    throw;
                }
                return conn;

            }

        }
    }
}
