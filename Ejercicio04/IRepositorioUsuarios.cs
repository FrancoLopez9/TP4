using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    interface IRepositorioUsuarios
    {
        void Agregar(Usuario pUsuario);

        void Eliminar(String pCodigo);

        void Actualizar(Usuario pUsuario);

        IList<Usuario> ObtenerTodos();

        Usuario ObtenerPorCodigo(String pCodigo);
        
        IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
        
    }
}
