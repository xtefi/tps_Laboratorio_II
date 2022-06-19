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
        private int id;
        private string cuit;
        private string patente;
        private string nombre;
        private long toneladas;
        private Granos.Grano tipoGrano;
        private DateTime fechaIngreso;
        private DateTime fechaDescarga;

        #region PROPIEDADES
        public int Id {
            get => this.id;
            set => this.id = value;
        }
        public string Nombre{ 
            get => this.nombre;
            set => this.nombre = value;
        }
        public string Patente { 
            get => this.patente; 
            set => this.patente = value;
        }
        public string Cuit { 
            get  => this.cuit;
            set => this.cuit = value;  
        }
        public DateTime FechaIngreso { 
            get => this.fechaIngreso; 
            set => this.fechaIngreso = value; 
        }
        public long Toneladas {
            get => this.toneladas; 
            set => this.toneladas = value; 
        }
        public Granos.Grano TipoGrano { 
            get => this.tipoGrano;
            set => this.tipoGrano = value; 
        } 
        public DateTime FechaDescarga {
            get => this.fechaDescarga;  
            set => this.fechaDescarga = value; 
        }
        #endregion
        public Transportista()
        {

        }
        public Transportista(string cuit, string nombre, string patente, long toneladas, Granos.Grano tipoGrano)
        {
            this.Cuit = cuit;
            this.Nombre = nombre;
            this.Patente = patente;
            this.Toneladas = toneladas;
            this.TipoGrano = tipoGrano;
            this.FechaIngreso = DateTime.Now;
            this.FechaDescarga = DateTime.MinValue;
        }
        public Transportista(string cuit, string nombre, string patente, long toneladas, Granos.Grano tipoGrano, DateTime fechaIngreso, DateTime fechaDescarga, int id)
            :this(cuit, nombre, patente, toneladas, tipoGrano)
        {
            this.FechaIngreso = fechaIngreso;
            this.FechaDescarga = fechaDescarga;
            this.Id = id;
        }

    }
}
