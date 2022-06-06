using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Enumerados;

namespace Entidades
{
    public class Productor
    {
        private string cuil;
        private string nombre;
        private long facturacion;
        private List<Transportista> transportistas;


        #region PROPIEDADES
        public string Cuil
        {
            get { return this.cuil; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public long Facturacion
        {
            get { return this.facturacion; }
            set { this.facturacion = value; }
        }
        public List<Transportista> Transportistas { get { return this.transportistas; } }

        #endregion  
        private Productor()
        {
            transportistas = new List<Transportista>();
        }
        public Productor(string nombre, string cuil)
            :this()
        {
            this.nombre = nombre;
            this.cuil = cuil;
        }
        /// <summary>
        /// Realiza la facturación mensual dependiendo de la cantidad de camiones ingresados por el productor
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        /// 

        /*
        public void Facturar(string mes)
        {
            long auxiliarFacutaricon=0;
            switch(mes)
            {
                case "enero":
                {
                    foreach(Transportista item in Transportistas)
                    {
                        if(item.Mes == 1)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "febrero":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 2)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "marzo":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 3)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "abril":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 4)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "mayo":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 5)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "junio":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 6)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "julio":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 7)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "agosto":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 8)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "septiembre":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 9)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "octubre":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 10)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "noviembre":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 11)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
                case "diciembre":
                {
                    foreach (Transportista item in Transportistas)
                    {
                        if (item.Mes == 12)
                        {
                            auxiliarFacutaricon += (item.FacturarCamion(item.TipoGrano, item.PrecioTonelada));
                        }
                    }
                    break;
                }
            }
            this.Facturacion = auxiliarFacutaricon;
        }
        */
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Cuil: {this.Cuil}");

                return sb.ToString();
        }

        public string MostrarTransportes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Transportista item in transportistas)
            {
                sb.AppendLine($"{item.MostrarDatos()}");
            }
            return sb.ToString();
        }

        public static Productor operator +(Productor p, Transportista t)
        {
            p.Transportistas.Add(t);
            return p;
        }

    }
}
