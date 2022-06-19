using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;

namespace Entidades
{
    public class Serializadora <T> where T : class, new()
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
            using(XmlTextReader xmlReader = new XmlTextReader(path))
            {
                List<Transportista> listaTransportistas;
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                listaTransportistas = serializer.Deserialize(xmlReader) as List<Transportista>;
                return listaTransportistas;
            }
        }

        public void GuardarJSON(T objeto, string path)
        {
          
                JsonSerializerOptions opcion = new JsonSerializerOptions();
                opcion.WriteIndented = true;

                string json = JsonSerializer.Serialize(objeto, opcion);
                Archivador.Escribir(path, json, true);/*
                Archivador archivador = new Archivador();
                archivador.Escribir1(JsonSerializer.Serialize(objeto, typeof(T)), path, true);
           */


            
        }

        public T LeerJSON(string path)
        {
            string json = Archivador.Leer(path);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
