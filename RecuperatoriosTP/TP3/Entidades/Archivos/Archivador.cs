using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivador : IArchivos<string>
    {

        public void Escribir(string dato, string path, bool append)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path, append)) // false pisa los datos que tengo, true agrega dato
                {
                    sw.WriteLine(dato);
                }
            }
            catch(Exception)
            {
                throw;
            }          
        }
        public string Leer(string path)
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
            catch(Exception)
            {
                throw;
            }
            return retornoAux;
        }
    }
}
