using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        static public bool AddCliente(Cliente c, int cod,string user, string pw)
        {
            if(Autenticacao.Autentication(user,pw) == true)
            {
                return Hoteis.AddCliente(c, cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return false;
        }
        /// <summary>
        /// Remove utilizador validando o login
        /// </summary>
        /// <param name="numC"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public bool RemoveCliente(int numC, int cod, string user, string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.RemoveCliente(numC, cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return false;
        }
        /// <summary>
        /// Devolve informaçao do utilizador validando o login
        /// </summary>
        /// <param name="numC"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public List<Cliente> RegistoCliente(int numC,int cod,string user,string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.InfoCliente(numC, cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return null;
        }
        /// <summary>
        /// Procura cliente validando login
        /// </summary>
        /// <param name="numC"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public Cliente GetCliente(int numC,int cod, string user, string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.GetCliente(numC, cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return null;
        }
    }
}
