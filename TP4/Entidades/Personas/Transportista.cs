using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Enumerados;

namespace Entidades.Personas
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
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Patente
        {
            get => patente;
            set => patente = value;
        }
        public string Cuit
        {
            get => cuit;
            set => cuit = value;
        }
        public DateTime FechaIngreso
        {
            get => fechaIngreso;
            set => fechaIngreso = value;
        }
        public long Toneladas
        {
            get => toneladas;
            set => toneladas = value;
        }
        public Granos.Grano TipoGrano
        {
            get => tipoGrano;
            set => tipoGrano = value;
        }
        public DateTime FechaDescarga
        {
            get => fechaDescarga;
            set => fechaDescarga = value;
        }
        #endregion
        public Transportista()
        {

        }
        public Transportista(string cuit, string nombre, string patente, long toneladas, Granos.Grano tipoGrano)
        {
            Cuit = cuit;
            Nombre = nombre;
            Patente = patente;
            Toneladas = toneladas;
            TipoGrano = tipoGrano;
            FechaIngreso = DateTime.Now;
            FechaDescarga = DateTime.MinValue;
        }
        public Transportista(string cuit, string nombre, string patente, long toneladas, Granos.Grano tipoGrano, DateTime fechaIngreso, DateTime fechaDescarga, int id)
            : this(cuit, nombre, patente, toneladas, tipoGrano)
        {
            FechaIngreso = fechaIngreso;
            FechaDescarga = fechaDescarga;
            Id = id;
        }

    }
}
