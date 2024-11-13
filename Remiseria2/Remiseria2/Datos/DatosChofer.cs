using Remiseria2.Interfaz;
using Remiseria2.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2.Datos
{
    class DatosChofer
    {
        public class DatosChoferes : IChofer
        {
            public string actualizarChofer(Chofer _chofer)
            {
                throw new NotImplementedException();
            }

            public string agregarChofer(Chofer _chofer)
            {
                throw new NotImplementedException();
            }

            public Chofer buscarXchofer(string _dni)
            {
                throw new NotImplementedException();
            }

            public bool eliminarChofer(int _id)
            {
                throw new NotImplementedException();
            }

            public DataTable ListaChoferes()
            {
                throw new NotImplementedException();
            }

            public List<Chofer> listadoXapellido(string _apellido)
            {
                throw new NotImplementedException();
            }
        }

    }
}
