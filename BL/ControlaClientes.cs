using System;
using System.Collections.Generic;
using BO;
using DAO;

namespace BL
{
    public class ControlaClientes
    {
        /// <summary>
        /// Adiciona utilizador validando o login
        /// </summary>
        /// <param name="c"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public bool AddCliente(Cliente c, int cod)
        {
                return Hoteis.AddCliente(c, cod);        
        }
        /// <summary>
        /// Remove utilizador validando o login
        /// </summary>
        /// <param name="numC"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public bool RemoveCliente(int numC, int cod)
        { 
                return Hoteis.RemoveCliente(numC, cod);
  
        }
        /// <summary>
        /// Devolve informaçao do utilizador validando o login
        /// </summary>
        /// <param name="numC"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public List<Cliente> RegistoCliente(int numC,int cod)
        {
    
                return Hoteis.InfoCliente(numC, cod);
          
        }
        /// <summary>
        /// Procura cliente validando login
        /// </summary>
        /// <param name="numC"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public Cliente GetCliente(int numC,int cod)
        {
                 
                return Hoteis.GetCliente(numC, cod);
        
        }
    }
}
