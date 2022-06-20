using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;
using Entidades.Personas;

namespace Entidades.Datos
{
    public class Serializadora<T> : IArchivos<T> where T : class
    {
        public static void GuardarXml(T objeto, string path)
        {
            //using(StreamWriter sw = new StreamWriter(path))
            using (XmlTextWriter xmlTextW = new XmlTextWriter(path, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                xmlTextW.Formatting = Formatting.Indented;

                serializer.Serialize(xmlTextW, objeto);
            }
        }
        public static List<Transportista> LeerXml(string path)
        {
            //using(StreamReader sr = new StreamReader(path))
            using (XmlTextReader xmlReader = new XmlTextReader(path))
            {
                List<Transportista> listaTransportistas;
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                listaTransportistas = serializer.Deserialize(xmlReader) as List<Transportista>;
                return listaTransportistas;
            }
        }
        /// <summary>
        /// Guarda archivos en formato JSON
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="path"></param>
        public void Guardar(T objeto, string path)
        {
            try
            {
                if (Path.GetExtension(path) == ".json")
                {
                    Archivador.Escribir(JsonSerializer.Serialize(objeto, typeof(T)), path);
                }
                else
                {
                    throw new ExtensionInvalidaException("Extensión inválida para JSON");
                }
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Lee archivos en formato JSON
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public T Leer(string path)
        {
            string json = Archivador.Leer(path);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
