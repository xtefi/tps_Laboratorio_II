using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region ATRIBUTOS
        /// <summary>
        /// marca lista de marcas disponibles
        /// chasis lista de chasis disponibles
        /// color color del vehículo
        /// </summary>
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        #endregion

        #region ENUM
        /// <summary>
        /// Marcas disponibles de vehículos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, 
            Ford, 
            Renault, 
            Toyota, 
            BMW,
            Honda,
            HarleyDavidson
        }
        /// <summary>
        /// Tamaños disponibles de vehículos
        /// </summary>
        public enum ETamanio
        {
            Chico,
            Mediano,
            Grande
        }
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor de vehículos
        /// </summary>
        /// <param name="chasis"> tipo de chasis del vehículo </param>
        /// <param name="marca"> tipo de marca del vehículo </param>
        /// <param name="color"> color  del vehículo </param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio 
        { 
            get;
        }
        #endregion

        #region MÉTODOS
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }        
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
        #endregion

    }
}
