using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor de tipo Ciclomotor
        /// </summary>
        /// <param name="marca">Se asigna una marca de las disponibles en base</param>
        /// <param name="chasis">para Ciclomotor chasis es tamaño "grande"</param>
        /// <param name="color"> color del Ciclomotor</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            :base (chasis, marca, color)
        {
        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region MÉTODOS
        /// <summary>
        /// Publica todos los datos de tipo Ciclomotor.
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
