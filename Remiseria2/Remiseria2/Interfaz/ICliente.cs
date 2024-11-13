using Remiseria2.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2.Interfaz
{
    internal interface ICliente
    {

        string agregarCliente(Cliente _cliente);

        bool eliminarCliente(int _id);
        string actualizarCliente(Cliente _cliente);


        Chofer buscarXcliente(string _dni);

        DataTable ListaCliente();

        List<Chofer> listadoXapellido(string _apellido);
    }
}
