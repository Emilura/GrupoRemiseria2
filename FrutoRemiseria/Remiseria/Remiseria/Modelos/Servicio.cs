using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria.Modelo
{
    public class Servicio
    {
        private int id_Servicio;
        private int id_Cliente;
        private int id_Vehiculo;
        private int id_chofer;
        private DateTime fecha;
        private DateTime horaInicio;
        private DateTime horaFin;
        private string origen;
        private string destino;
        private float precio;
        private string estado;
        private bool activo;

        public Servicio(int id_Servicio, int id_Cliente, int id_Vehiculo, int id_chofer, DateTime fecha, DateTime horaInicio, DateTime horaFin, string origen, string destino, float precio, string estado, bool activo)
        {
            this.id_Servicio = id_Servicio;
            this.id_Cliente = id_Cliente;
            this.id_Vehiculo = id_Vehiculo;
            this.id_chofer = id_chofer;
            this.fecha = fecha;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.origen = origen;
            this.destino = destino;
            this.precio = precio;
            this.estado = estado;
            this.activo = activo;
        }

        public int Id_Servicio { get => id_Servicio; set => id_Servicio = value; }
        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public int Id_Vehiculo { get => id_Vehiculo; set => id_Vehiculo = value; }
        public int Id_chofer { get => id_chofer; set => id_chofer = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public string Origen { get => origen; set => origen = value; }
        public string Destino { get => destino; set => destino = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
