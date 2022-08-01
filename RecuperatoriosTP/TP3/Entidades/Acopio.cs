using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Acopio
    {
        private int toneladas;
        private Enumerados.Granos.Grano tipoGrano;
        private double humedad;

        public Acopio() // El silo siempre se instanciará vacío
        {
            this.Toneladas = 0;
            this.Humedad = 0;
            this.TipoGrano = Enumerados.Granos.Grano.Vacio;
        }

        #region PROPIEDADES
        public int Toneladas { get { return this.toneladas; } set { this.toneladas = value; } }
        public double Humedad { get { return this.humedad; } set { this.humedad = value; } }
        public Enumerados.Granos.Grano TipoGrano 
        { 
            get => tipoGrano;  
            set 
            {
                this.tipoGrano = (Enumerados.Granos.Grano)value;
            } 
        }
        #endregion
        #region METODOS
        /// <summary>
        /// Informa capacidad disponible en silo, máximo 1000 toneladas
        /// </summary>
        /// <returns></returns>
        public int AlmacenamientoDisponible()
        {
            try
            {
                if (this.Toneladas == 0)
                {
                    return 1000;
                }
                else
                {
                    return (1000 - this.Toneladas);
                }
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Llena silo
        /// </summary>
        /// <param name="toneladas"></param>
        /// <param name="humedad"></param>
        /// <returns></returns>
        public bool LlenarSilo(int toneladas, double humedad)
        {
            try
            {

                if (toneladas <= AlmacenamientoDisponible()
                    && toneladas > 0 && toneladas <= 1000 && humedad >=0 && humedad <= 100)
                {
                    this.Toneladas += toneladas;
                    this.Humedad = ((humedad + this.Humedad) / 2);
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                throw ;
            }
        }
        /// <summary>
        /// Vacía el silo
        /// </summary>
        /// <param name="toneladas"></param>
        /// <returns> 0 si descuenta toneladas // 1 si no descuenta toneladas</returns>
        public int VaciarSilo(int toneladas)
        {
            try
            {
                if (this.Toneladas > 0 && toneladas <= this.Toneladas)
                {
                    this.Toneladas -= toneladas;
                    return 0;
                }
                else return 1;
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Devuelve información del silo
        /// </summary>
        /// <returns></returns>
        public string InformacionSilo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Este silo contiene {0}\n", TipoGrano);
            sb.AppendFormat("Humedad: {0}%\n", Math.Round(Humedad,2));
            sb.AppendFormat($"Cantidad guardada: {1000 - AlmacenamientoDisponible()}tn\n");
            sb.AppendFormat("Espacio disponible: {0}tn", AlmacenamientoDisponible());

            return sb.ToString();
        }
        #endregion

    }
}
