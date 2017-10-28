using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    /// <summary>
    /// Clase que implementa los metodos de la interfaz IRepositorioUsuarios.
    /// </summary>
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private IDictionary<String, Usuario> iDiccionario = new SortedDictionary<String, Usuario>();

        public IDictionary<String, Usuario> Diccionario
        {
            get { return this.iDiccionario; }
            set { iDiccionario = value; }
        }

        /// <summary>
        /// Metodo que agrega un usuario al diccionario.
        /// </summary>
        /// <param name="pUsuario">Usuario a agregar</param>
        public void Agregar(Usuario pUsuario)
        {
            iDiccionario.Add(pUsuario.Codigo, pUsuario);
        }

        /// <summary>
        /// Metodo que elimina un usuario al diccionario.
        /// </summary>
        /// <param name="pCodigo">Codigo del Usuario a eliminar</param>
        public void Eliminar(String pCodigo)
        {
            iDiccionario.Remove(pCodigo);
        }

        /// <summary>
        /// Metodo que actualiza un usuario del diccionario.
        /// </summary>
        /// <param name="pUsuario">Usuario a actualizar</param>
        public void Actualizar(Usuario pUsuario)
        {
            iDiccionario [pUsuario.Codigo] = pUsuario;
            
        }

        /// <summary>
        /// Metodo que obtiene todos los usuarios y los devuelve en una lista.
        /// </summary>
        /// <returns></returns>
        public IList<Usuario> ObtenerTodos()
        {
            return new List<Usuario>(iDiccionario.Values);
        }

        /// <summary>
        /// Metodo que obtiene un usuario segun el codigo que se le pase
        /// </summary>
        /// <param name="pCodigo">Codigo del Usuario a obtener</param>
        /// <returns></returns>
        public Usuario ObtenerPorCodigo(String pCodigo)
        {
            return iDiccionario[pCodigo];
        }

        /// <summary>
        /// Metodo que obtiene todos los usuarios ordenados segun un criterio dado
        /// </summary>
        /// <param name="pComparador">Criterio de ordenamiento</param>
        /// <returns></returns>
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> pLista = new List<Usuario>(Diccionario.Values);
            pLista.Sort(pComparador);
            return pLista;
        }
    }
}
