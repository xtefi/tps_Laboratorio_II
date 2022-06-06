using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Enumerados;

namespace Entidades
{
    public class Transportista
    {
        private string cuit;
        private string patente;
        private string nombre;
        private long toneladas;
        private Granos.Grano tipoGrano;
        private DateTime fecha;
        private long precioTonelada;

        public string Nombre { get { return this.nombre; } }
        public string Patente { get { return this.patente; } }
        public string Cuit { get { return this.cuit; } }
        public DateTime Fecha { get { return this.fecha; } }
        public long Toneladas { get { return this.toneladas; } }
        public Granos.Grano TipoGrano { get { return this.tipoGrano; } }
        public long PrecioTonelada { 
            get { return this.precioTonelada; } 
            set { this.precioTonelada = value; } 
        }

        public Transportista(string cuit, string nombre, string patente, long toneladas, Granos.Grano tipoGrano, long precioTonelada)
        {
            this.cuit = cuit;
            this.nombre = nombre;
            this.patente = patente;
            this.toneladas = toneladas;
            this.tipoGrano = tipoGrano;
            this.PrecioTonelada = precioTonelada;
            this.fecha = DateTime.Now;
        }

        public long FacturarCamion(Granos.Grano tipoGrano, long precioTonelada)
        {
            long valor=0;
            try
            {
                switch (tipoGrano)
                {
                    case Granos.Grano.Girasol:
                        valor = toneladas * precioTonelada;
                        break;
                    case Granos.Grano.Maíz:
                        valor = toneladas * precioTonelada;
                        break;
                    case Granos.Grano.Soja:
                        valor = toneladas * precioTonelada;
                        break;
                    case Granos.Grano.Trigo:
                        valor = toneladas * precioTonelada;
                        break;
                }
            }
            catch
            {

            }
            return valor;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Cuil: {this.Cuit}");
            sb.AppendLine($"Toneladas: {this.Toneladas}");
            sb.AppendLine($"Tipo grano: {this.TipoGrano}");
            return sb.ToString();
        }
    }
}
