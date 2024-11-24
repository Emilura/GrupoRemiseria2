using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Modelo
{
    public class Vehiculo
    {
        private int idVehiculo;
        private string patente;
        private string marca;
        private string modelo;
        private string año;
        private string estado;
        private bool activo;



        public Vehiculo()
        {

        }
        public Vehiculo(int idVehiculo, string patente, string marca, string modelo, string año, string estado, bool activo)
        {
            this.idVehiculo = idVehiculo;
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.estado = estado;
            this.activo = activo;
        }

        public Vehiculo( string patente, string marca, string modelo, string año, string estado, bool activo)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.estado = estado;
            this.activo = activo;
        }

        
    }
}
