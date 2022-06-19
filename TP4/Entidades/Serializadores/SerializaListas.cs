using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public static class SerializaListas
    {/*
        static string ruta;
        static SerializaListas()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
        public static List<Transportista> LeerLista()
        {
            string completa = ruta + @"\transportista.xml0";
            List<Transportista> tr = null;
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamReader sr = new StreamReader(completa))
                {
                    XmlSerializer xmlSerial = new XmlSerializer(typeof(List<Transportista>));
                    tr = (List<Transportista>)xmlSerial.Deserialize(sr);
                }
                return tr;
            }
            catch (Exception e)
            {
                throw new Exception("Extensión inválida para XML");
            }
        }*/
    }
}
