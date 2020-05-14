using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAO;


namespace BL
{
    public class ControlaQuartos
    {
        /// <summary>
        /// Adiciona Quarto validando login
        /// </summary>
        /// <param name="q"></param>
        /// <param name="numQ"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public bool AddQuarto(Quarto q,int numQ, int cod,string user, string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.AddQuarto(q, numQ, cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return false;
        }
          /// <summary>
          /// Remove Quarto validando login
          /// </summary>
          /// <param name="q"></param>
          /// <param name="numQ"></param>
          /// <param name="cod"></param>
          /// <param name="user"></param>
          /// <param name="pw"></param>
          /// <returns></returns>
        static public Registo RemoveQuarto(int numQ, int cod, string user, string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.RemoveQuarto(numQ, cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return Registo.NaoEfetuado;
        }
        
        /// <summary>
        /// Efetua checkin verificando login
        /// </summary>
        /// <param name="c"></param>
        /// <param name="check"></param>
        /// <param name="numQ"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public bool EfetuarCheckIn(Cliente c, DateTime check,int numQ, int cod, string user, string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.EfetuarCheckIn(c, check, numQ, cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="precoDia"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public double EfetuaPagamento(int numQ,double precoDia, int cod, string user, string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.EfetuarPagamento(numQ, precoDia, cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return -1;
        }
        /// <summary>
        /// devolve info quarto validando login
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public Quarto InfoQuarto(int numQ,int cod,string user, string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.InfoQuarto(numQ, cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return null;
        }
    }
}
