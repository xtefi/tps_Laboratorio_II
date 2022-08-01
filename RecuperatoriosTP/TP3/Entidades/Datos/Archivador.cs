using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Datos
{
    public class Archivador
    {
        public Archivador()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ruta = Path.Join(ruta, "misArchivitos");

        }
        public static void Escribir(string dato, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path)) // false pisa los datos que tengo, true agrega dato
                {
                    sw.WriteLine(dato);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string Leer(string path)
        {
            string retornoAux = string.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream) // mientras no sea el fin del archivo
                    {
                        retornoAux += $"{sr.ReadLine()}\n"; // leo y lo concateno
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error al leer el arhcivo {path}");
            }
            return retornoAux;
        }
    }
}
