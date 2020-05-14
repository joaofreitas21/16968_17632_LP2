using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAO;

namespace BL
{
    public class ControlaHoteis
    {
      /// <summary>
      /// Adiciona hotel validando as condiçoes
      /// </summary>
      /// <param name="hotel"></param>
      /// <param name="user"></param>
      /// <param name="pw"></param>
      /// <returns></returns>
        static public bool AddHotel(HotelBO hotel, string user, string pw)
        {
            if (hotel.MaxQuartos != 0 && hotel.MaxQuartos <= 100 && (Autenticacao.Autentication(user, pw) == true))
            {
                return Hoteis.AddHotel(hotel);
            }
            Console.WriteLine("Capacidade invalida ou Autenticacao falhada!");
            return false;
        }
        /// <summary>
        /// Remove o hotel pelo codigo
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public bool RemoveHotel(int cod, string user, string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.RemoveHotel(cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return false;
        }
        /// <summary>
        /// Devolve numero de quartos livres no Hotel q escolhe
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public List<int> NumQuartosLivres(int cod, string user, string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.NumQuartosLivres(cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return null;
        }
       /// <summary>
       /// Devolve informaçao do codigo validando login
       /// </summary>
       /// <param name="cod"></param>
       /// <param name="user"></param>
       /// <param name="pw"></param>
       /// <returns></returns>
        static public HotelBO InfoHotel(int cod,string user,string pw)
        {
            if (Autenticacao.Autentication(user, pw) == true)
            {
                return Hoteis.InfoHotel(cod);
            }
            Console.WriteLine("Autenticacao falhada!");
            return null;
        }
        /// <summary>
        /// Guarda hotel em ficheiro binario
        /// </summary>
        /// <param name="nomFicheiro"></param>
        /// <returns></returns>
        static public bool Save(string nomFicheiro)
        {
            return Hoteis.Save(nomFicheiro);
        }
        /// <summary>
        /// Carrega ficheiro à priori gravado em binario
        /// </summary>
        /// <param name="nomFicheiro"></param>
        /// <returns></returns>
        static public bool Load(string nomFicheiro)
        {
            return Hoteis.Load(nomFicheiro);
        }
    }
}
