using Remiseria2.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2.Interfaz
{
    internal interface IChofer
    {
        string agregarChofer(Chofer _chofer);

        bool eliminarChofer(int _id);
        string actualizarChofer(Chofer _chofer);


        Chofer buscarXchofer(string _dni);

        DataTable ListaChoferes();

        List<Chofer> listadoXapellido(string _apellido);


    }
}
