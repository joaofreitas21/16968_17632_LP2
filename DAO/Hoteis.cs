using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace DAO
{
    [Serializable]
    public class Hoteis
    {
        #region ESTADO
        static List<Hotel> hoteis = new List<Hotel>();
        static int quantHoteis = 0;
        #endregion

        #region METODOS_CLASSE
        #region METODO_HOTEL
        /// <summary>
        /// Procura o Hotel na Lista atraves do codigo unico
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public bool ProcuraHotel(int cod)
        {
            for (int i = 0; i < quantHoteis; i++)
            {
                if (hoteis[i].Cod.CompareTo(cod) == 0 )
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Devolve info do Hotel que procura na lista de Hoteis
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public HotelBO InfoHotel(int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != -1)
            {
                return hoteis[key].DevolveInfo();
            }
            else return new HotelBO(null, null, 1,-1);
        }
        /// <summary>
        /// Adiciona Hotel à lista
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        static public bool AddHotel(HotelBO hotel)
        {
            if (ProcuraHotel(hotel.Cod) == false)
            {
                Hotel h = new Hotel(hotel.MaxQuartos);
                h.GuardaInfoHotel(hotel);
                //hoteis[quantHoteis] = h;
                //quantHoteis++;
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Remove Hotel com base no codigo da Lista Hoteis
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public bool RemoveHotel(int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != -1)
            {
                hoteis.RemoveAt(key);
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Metodo Save -msdn 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public bool Save(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, hoteis);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                Console.Write("ERRO:" + e.Message);
                return false;
            }
        }
        /// <summary>
        /// Metodo load - msdn
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public bool Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    hoteis = (List<Hotel>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    Console.Write("ERRO:" + e.Message);
                    return false;
                }
            }
            return false;
        }

        #endregion
        #region METODO_QUARTOS
        /// <summary>
        /// Adiciona quartos ao hotel ID(x)
        /// </summary>
        /// <param name="q"></param>
        /// <param name="numQ"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public bool AddQuarto(Quarto q,int numQ,int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != -1 ) // hoteis[key].MaxQuartos >= numQ)
            {
                hoteis[key].AddRegistoQuarto(q, numQ);
                AddCliente(q.Cli, cod);
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Remove registo Quarto com base no ID do hotel
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public Registo RemoveQuarto(int numQ,int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != -1 && hoteis[key].MaxQuartos >= numQ)
            {
                return hoteis[key].RemoverRegistoQuarto(numQ);

            }
            else return Registo.NaoEfetuado;
        }
        /// <summary>
        /// Efetua check-in
        /// </summary>
        /// <param name="c"></param>
        /// <param name="check"></param>
        /// <param name="numQ"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public bool EfetuarCheckIn(Cliente c, DateTime check, int numQ, int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != -1 && hoteis[key].MaxQuartos >= numQ)
            {
                return hoteis[key].EfetuarCheckIn(c, check, numQ);
            }
            else return false;

        }
        /// <summary>
        /// Efetua pagamento
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="precoDia"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public double EfetuarPagamento(int numQ,double precoDia,int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != -1 && hoteis[key].MaxQuartos >= numQ)
            {
                return hoteis[key].EfetuarPagamento(numQ, precoDia);
            }
            else return -1;
        }
        /// <summary>
        /// Devolve informaçao do quarto
        /// </summary>
        /// <param name="numQ"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public Quarto InfoQuarto(int numQ,int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != -1 && hoteis[key].MaxQuartos >= numQ)
            {
                return hoteis[key].FichaQuarto(numQ);
            }
            else return new Quarto();
        }
        /// <summary>
        /// devolve nº de quartos livres no hotel (cod)
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public List<int> NumQuartosLivres(int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != -1)
            {
                return hoteis[key].QuartosLivres();
            }
            else return null;
        }

        #endregion
        #region METODO_CLIENTE
        /// <summary>
        /// Adiciona cliente no hotel(key)
        /// </summary>
        /// <param name="c"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public bool AddCliente(Cliente c,int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != 0)
            {
                hoteis[key].AddCliente(c);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Remove Cliente do hotel(key)
        /// </summary>
        /// <param name="numC"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public bool RemoveCliente(int numC,int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != 0)
            {
                return hoteis[key].RemoveCliente(numC);
            }
            else return false;

        }
       /// <summary>
       /// Lista Info do Cliente c no hotel(key)
       /// </summary>
       /// <param name="numC"></param>
       /// <param name="cod"></param>
       /// <returns></returns>
        static public List<Cliente> InfoCliente(int numC,int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != 0)
            {
                return hoteis[key].FichaCliente(numC);
            }
            else return null;
        }
        static public Cliente GetCliente(int numC,int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != 0)
            {
                return hoteis[key].ProcuraClient(numC);
            }
            else return null;
        }
        #endregion
        #region METODO_EMPREGADOS
        /// <summary>
        /// Adiciona empregado no hotel(key)
        /// </summary>
        /// <param name="c"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public bool AddEmpregado(Empregado e, int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != 0)
            {
                hoteis[key].AddEmpregado(e);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Remove empregado do hotel(key)
        /// </summary>
        /// <param name="numC"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public bool RemoveEmpregado(int numE, int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != 0)
            {
                return hoteis[key].RemoveEmpregado(numE);
            }
            else return false;

        }
        /// <summary>
        /// Lista Info do Empregado e no hotel(key)
        /// </summary>
        /// <param name="numE"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public List<Empregado> InfoEmpregado(int numE, int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != 0)
            {
                return hoteis[key].FichaEmpregado(numE);
            }
            else return null;
        }
        /// <summary>
        /// Procura empregado validando login
        /// </summary>
        /// <param name="numE"></param>
        /// <param name="cod"></param>
        /// <returns></returns>
        static public Empregado GetEmpregado(int numE, int cod)
        {
            int key = Convert.ToInt32(ProcuraHotel(cod));
            if (key != 0)
            {
                return hoteis[key].ProcuraOEmpregado(numE);
            }
            else return null;
        }
        #endregion
        #endregion
    }
}
