using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Modelo
{
    public class Cliente
    {

        private string apellido;
        private string nombre;
        private string telefono;
        private string direccion;
        private string email;
        private bool activo;


        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public bool Activo { get => activo; set => activo = value; }


        public Cliente(){}
        public Cliente(string apellido, string nombre, string telefono, string direccion, string email, bool activo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.activo = activo;
        }

       
    }
}
