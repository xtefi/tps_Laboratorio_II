using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivador //: IArchivos<string>
    {
        public Archivador()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ruta = Path.Join(ruta, "misArchivitos");
            
        }
        public static void Escribir(string dato, string path, bool pisarDatos)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path, pisarDatos)) // false pisa los datos que tengo, true agrega dato
                {
                    sw.WriteLine(dato);
                }
            }
            catch(Exception)
            {
                throw;
            }          
        }
        public void Escribir1(string dato, string path, bool pisarDatos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, pisarDatos)) // false pisa los datos que tengo, true agrega dato
                {
                    sw.WriteLine(dato);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public  string Leer1(string path)
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
        public static string Leer(string path)
        {
            string retornoAux = string.Empty;

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    while(!sr.EndOfStream) // mientras no sea el fin del archivo
                    {
                        retornoAux += $"{sr.ReadLine()}\n"; // leo y lo concateno
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception($"Error al leer el arhcivo {path}");
            }
            return retornoAux;
        }
    }
}
