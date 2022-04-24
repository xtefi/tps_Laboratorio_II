﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        #region ATRIBUTOS
        /// <summary>
        /// vehiculos: lista de vehiculos inicializada en constructor
        /// espacioDisponible: cantidad de vehículos que pueden ingresar al taller
        ///                     
        /// </summary>
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        #endregion

        #region ENUM
        /// <summary>
        ///  Tipo de vehículos que se admiten en el taller
        /// </summary>
        public enum ETipo
        {
            Moto, 
            Automovil,
            Camioneta, 
            Todos
        }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// private Estacionamiento: inicializa la lista de vehiculos        
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        /// <summary>
        /// Obtiene la lista ya inicializada y asigna espacioDisponible
        /// </summary>
        /// <param name="espacioDisponible"> espacio para ingresar nuevo vehículo </param>
        public Taller(int espacioDisponible)
            :this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region MÉTODOS

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Camioneta:   
                        if (v is Suv)                     
                            sb.AppendLine(v.Mostrar());                                                
                        break;
                    case ETipo.Moto:
                        if(v is Ciclomotor)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Automovil:
                        if(v is Sedan)
                            sb.AppendLine(v.Mostrar());
                        break;
                    default:
                            sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region OPERADORES
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if(taller.vehiculos.Count < taller.espacioDisponible)
            {
                foreach(Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                        return taller;
                }
                taller.vehiculos.Add(vehiculo);
            }            
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            if (taller.vehiculos.Contains(vehiculo))
                {
                    taller.vehiculos.Remove(vehiculo);                   
                }
           
            return taller;
        }
        #endregion
    }
}
