using BO;
using DAO;
using System;


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
        static public bool AddQuarto(Quarto q,int numQ, int cod)
        {
   
            
                return Hoteis.AddQuarto(q, numQ, cod);
            
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
        static public Registo RemoveQuarto(int numQ, int cod)
        {

                return Hoteis.RemoveQuarto(numQ, cod);
           
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
        static public bool EfetuarCheckIn(Cliente c, DateTime check,int numQ, int cod)
        {
            
            return Hoteis.EfetuarCheckIn(c, check, numQ, cod);
           
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
        static public double EfetuaPagamento(int numQ,double precoDia, int cod)
        {
           
            
                return Hoteis.EfetuarPagamento(numQ, precoDia, cod);
            
        }
        /// <summary>
        /// devolve info quarto validando login
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public Quarto InfoQuarto(int numQ,int cod)
        {
    
                return Hoteis.InfoQuarto(numQ, cod);
           
        }
    }
}
