    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Modelo
{
    public class Chofer
    {

        private int IdChofer;
        private string apellido;
        private string nombre;
        private string licenciaConducir;
        private bool activo;


        public int IdChofer1 { get => IdChofer; set => IdChofer = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string LicenciaConducir { get => licenciaConducir; set => licenciaConducir = value; }
        public bool Activo { get => activo; set => activo = value; }
        
        public Chofer()
        {

        }

        public Chofer(int idChofer, string apellido, string nombre, string licenciaConducir, bool activo)
        {
            this.IdChofer = idChofer;
            this.apellido = apellido;
            this.nombre = nombre;
            this.licenciaConducir = licenciaConducir;
            this.activo = activo;
        }

        public Chofer( string apellido, string nombre, string licenciaConducir, bool activo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.licenciaConducir = licenciaConducir;
            this.activo = activo;
        }

    }
}
