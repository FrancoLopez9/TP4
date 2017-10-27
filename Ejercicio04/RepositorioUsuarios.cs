using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class RepositorioUsuarios : IRepositorioUsuarios
    {
        private IDictionary<String, Usuario> iDiccionario = new SortedDictionary<String, Usuario>();

        public void Agregar(Usuario pUsuario)
        {
            iDiccionario.Add(pUsuario.Codigo, pUsuario);
        }

        public void Eliminar(String pCodigo)
        {
            iDiccionario.Remove(pCodigo);
        }

        public void Actualizar(Usuario pUsuario)
        {
            iDiccionario [pUsuario.Codigo] = pUsuario;
            
        }

        public IList<Usuario> ObtenerTodos()
        {
            return new List<Usuario>(iDiccionario.Values);
        }

        public Usuario ObtenerPorCodigo(String pCodigo)
        {
            return iDiccionario[pCodigo];
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {

        }
    }
}
