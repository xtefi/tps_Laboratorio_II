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
        private DateTime fechaIngreso;
        private long precioTonelada;
        private DateTime fechaDescarga;

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Patente { get { return this.patente; } }
        public string Cuit 
        { 
            get { return this.cuit; } 
            set
            {
                if(Convert.ToInt64(value) > 0)
                {
                    this.cuit = value;
                }
            }
        }
        public DateTime FechaIngreso { get { return this.fechaIngreso; } }
        public long Toneladas { get { return this.toneladas; } set { this.toneladas = value; } }
        public Granos.Grano TipoGrano { get { return this.tipoGrano; } }
        public long PrecioTonelada { 
            get { return this.precioTonelada; } 
            set { this.precioTonelada = value; } 
        }
        public DateTime FechaDescarga { get { return this.fechaDescarga; } set { this.fechaDescarga = value; } }

        public Transportista()
        {

        }
        public Transportista(string cuit, string nombre, string patente, long toneladas, Granos.Grano tipoGrano, long precioTonelada)
        {
            this.cuit = cuit;
            this.nombre = nombre;
            this.patente = patente;
            this.toneladas = toneladas;
            this.tipoGrano = tipoGrano;
            this.PrecioTonelada = precioTonelada;
            this.fechaIngreso = DateTime.Now;
            this.fechaDescarga = DateTime.MinValue;
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
        /*
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Cuil: {this.Cuit}");
            sb.AppendLine($"Toneladas: {this.Toneladas}");
            sb.AppendLine($"Tipo grano: {this.TipoGrano}");
            return sb.ToString();
        }*/
    }
}
