using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Datos
{
    public interface IArchivos<T> where T : class
    {
        T Leer(string path);
        void Guardar(T dato, string path);

    }
}
