using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    /// <summary>
    /// Clase que implementa los metodos de la interfaz IRepositorioUsuarios.
    /// </summary>
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private IList<Usuario> iLista = new List<Usuario>();

        public IList<Usuario> Lista
        {
            get { return this.iLista; }
            set { iLista = value; }
        }

        /// <summary>
        /// Metodo que agrega un usuario a la lista
        /// </summary>
        /// <param name="pUsuario">Usuario a agregar</param>
        public void Agregar(Usuario pUsuario)
        {
            if (iLista.Contains(pUsuario))
            {
                throw new UsuarioExistenteException("El usuario ya existe");
            }
            else
            {
                iLista.Add(pUsuario);
            }
        }

        /// <summary>
        /// Metodo que elimina un usuario de la lista
        /// </summary>
        /// <param name="pCodigo">Codigo del Usuario a eliminar</param>
        public void Eliminar(String pCodigo)
        {
            if (iLista.Contains(new Usuario (pCodigo)))
            {
                iLista.Remove(new Usuario(pCodigo));
            }
            else
            {
                throw new UsuarioInexistenteException("El usuario no existe");                
            }
            
        }

        /// <summary>
        /// Metodo que actualiza un usuario del diccionario.
        /// </summary>
        /// <param name="pUsuario">Usuario a actualizar</param>
        public void Actualizar(Usuario pUsuario)
        {
            if (iLista.Contains(pUsuario))
            {
                int index = iLista.IndexOf(pUsuario);
                iLista[index] = pUsuario;
            }
            
            else
            {
                throw new UsuarioInexistenteException("El usuario no existe");
            }

        }

        /// <summary>
        /// Metodo que obtiene todos los usuarios y los devuelve en una lista.
        /// </summary>
        /// <returns></returns>
        public IList<Usuario> ObtenerTodos()
        {
            return iLista;
        }

        /// <summary>
        /// Metodo que obtiene un usuario segun el codigo que se le pase
        /// </summary>
        /// <param name="pCodigo">Codigo del Usuario a obtener</param>
        /// <returns></returns>
        public Usuario ObtenerPorCodigo(String pCodigo)
        {
            if (iLista.Contains(new Usuario(pCodigo)))
            {
                int index = iLista.IndexOf(new Usuario(pCodigo));
                return iLista.ElementAt(index);
            }
            else
            {
                throw new UsuarioInexistenteException("El usuario no existe");
            }
        }

        /// <summary>
        /// Metodo que obtiene todos los usuarios ordenados segun un criterio dado
        /// </summary>
        /// <param name="pComparador">Criterio de ordenamiento</param>
        /// <returns></returns>
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> pLista = iLista.ToList();            
            pLista.Sort(pComparador);
            return pLista;
        }
    }
}
