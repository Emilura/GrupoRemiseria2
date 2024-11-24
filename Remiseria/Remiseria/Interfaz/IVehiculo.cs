using Remiseria.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2.Interfaz
{
    internal interface IVehiculo
    {
        string agregarVehiculo(Vehiculo _vehiculo);

        bool eliminarVehiculo(int _id);
        string actualizarVehiculo(Vehiculo _vehiculo);


        Chofer buscarXvehiculo(string _dni);

        DataTable ListaVehiculo();

        List<Chofer> listadoXapellido(string _apellido);

    }
}
