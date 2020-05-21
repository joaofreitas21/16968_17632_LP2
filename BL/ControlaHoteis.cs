using BO;
using DAO;
using System.Collections.Generic;

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
        static public bool AddHotel(HotelBO hotel)
        {
            if (hotel.MaxQuartos != 0 && hotel.MaxQuartos <= 100 )
            {
                return Hoteis.AddHotel(hotel);
            }
            
            return false;
        }
        /// <summary>
        /// Remove o hotel pelo codigo
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public bool RemoveHotel(int cod)
        {
            
            
                return Hoteis.RemoveHotel(cod);
           
        }
        /// <summary>
        /// Devolve numero de quartos livres no Hotel q escolhe
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="user"></param>
        /// <param name="pw"></param>
        /// <returns></returns>
        static public List<int> NumQuartosLivres(int cod)
        {
            
                return Hoteis.NumQuartosLivres(cod);
            
        }
       /// <summary>
       /// Devolve informaçao do codigo validando login
       /// </summary>
       /// <param name="cod"></param>
       /// <param name="user"></param>
       /// <param name="pw"></param>
       /// <returns></returns>
        static public HotelBO InfoHotel(int cod)
        {
            
            
                return Hoteis.InfoHotel(cod);
           
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
        /// <summary>s
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
