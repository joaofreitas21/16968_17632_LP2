using System;
using System.Collections;
using System.Collections.Generic;

namespace DAO
{
    class Clientes : IClientes
    {
        #region ESTADO
        private Hashtable clientes;
        int totalClientes;
        #endregion

        #region METODOS
        #region CONSTRUTORES
        
        public Clientes()
        {
            clientes = new Hashtable();
            totalClientes = 0;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipula o atributo total clientes
        /// </summary>
        public int TotalClientes
        {
            set { }
            get { return totalClientes; }
        }

        #endregion
        #region METODOS_CLASSE
        /// <summary>
        /// Devolve o codigo na hashtable
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int GetHashCode(Cliente c)
        {
            return c.NumeroCliente;
        }

        /// <summary>
        /// Metodo que guarda o cliente na HashTable
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool GuardaCliente(Cliente c)
         {

            int key = GetHashCode(c);
                    if (!clientes.ContainsKey(key))
                    {
                    clientes.Add(key, new List<Cliente>(100));
                    }
                    c.DataRegisto = DateTime.Now;
                    ((List<Cliente>)clientes[key]).Add(c);
                    totalClientes++;
                    return true;
            
        }

        /// <summary>
        /// Metodo que procura cliente pela key na HashTable
        /// </summary>
        /// <param name="c"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public int ProcuraCliente(Cliente c,DateTime time)
        {
            int key = GetHashCode(c);
            List<Cliente> a = ((List<Cliente>)(clientes[key]));
            if (a.Contains(c) == true)
            {
                int i = 0;
                foreach(Cliente cli in a) {
                    if (a[i].DataRegisto.Date == time.Date)
                    {
                        return i;
                    }
                    i++;
                }
                return 0;
            }
            else return 0;
        }

        /// <summary>
        /// Metodo que remove o cliente da hashtable
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool RemoveCliente(Cliente c)
        {
            
                int key = GetHashCode(c);
                ((List<Cliente>)(clientes[key])).Clear();
                totalClientes--;
            return true;
        }

        #endregion
        #region DEST
        ~Clientes()
        {

        }
        #endregion

        #endregion
    }
}
