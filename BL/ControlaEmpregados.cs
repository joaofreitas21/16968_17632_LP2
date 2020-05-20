using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAO;

namespace BL
{
    public class ControlaEmpregados
    {
        /// <summary>
        /// Adiciona empregado validando o login
        /// </summary>
        /// <param name="e"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public bool AddEmpregado(Empregado e, int cod)
        {
            
        
                return Hoteis.AddEmpregado(e, cod);
           
        }
        /// <summary>
        /// Remove empregado validando o login
        /// </summary>
        /// <param name="numE"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public bool RemoveEmpregado(int numE, int cod)
        {
            
           
                return Hoteis.RemoveEmpregado(numE, cod);
            
        }
        /// <summary>
        /// Devolve informaçao do Empregado validando o login
        /// </summary>
        /// <param name="numE"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public List<Empregado> RegistoEmpregado(int numE, int cod)
        {
          
                return Hoteis.InfoEmpregado(numE, cod);
        
        }
        /// <summary>
        /// Procura empregado validando login
        /// </summary>
        /// <param name="numC"></param>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public Empregado GetEmpregado(int numE, int cod)
        {
          
            
                return Hoteis.GetEmpregado(numE, cod);
            
        }
    }
}
