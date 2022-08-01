using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializador<T> : IArchivos<T> where T: class
    {
        private IArchivos<T>.ETipoArchivo tipo;

        public Serializador(IArchivos<T>.ETipoArchivo tipo)
        {
            this.tipo = tipo;
        }

        public void Escribir(T dato, string path, bool pisarDatos)
        {
            try
            {
                if(this.tipo == IArchivos<T>.ETipoArchivo.XML)
                {
                    if(Path.GetExtension(path) == ".xml")
                    {
                        using (XmlTextWriter xmlTextW = new XmlTextWriter(path, Encoding.UTF8))
                        {
                            xmlTextW.Formatting = Formatting.Indented;
                            XmlSerializer xmlSerial = new XmlSerializer(typeof(T));
                            xmlSerial.Serialize(xmlTextW, dato);
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extensión inválida para XML");
                    }
                }
                else
                {
                    if(Path.GetExtension(path) == ".json")
                    {
                        Archivador archivador = new Archivador();
                        archivador.Escribir1(JsonSerializer.Serialize(dato, typeof(T)), path, pisarDatos);
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extensión inválida para JSON");
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public T Leer(string path)
        {
            try
            {
                if(this.tipo == IArchivos<T>.ETipoArchivo.XML)
                {
                    if(Path.GetExtension(path) == ".xml")
                    {
                        using(XmlTextReader xmlReader = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSerial = new XmlSerializer(typeof(T));
                            return (T)xmlSerial.Deserialize(xmlReader);
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extensión inválida para XML");
                    }
                }
                else
                {
                    if(Path.GetExtension(path) == ".json")
                    {
                        Archivador archivador = new Archivador();
                        return JsonSerializer.Deserialize<T>(archivador.Leer1(path));
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extensión inválida para JSON");
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }       
    }
}
