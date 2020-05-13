using System;
using BO;
using System.Collections.Generic;

namespace DAO
{
    interface IHotel
    {
        bool EfetuarCheckIn(Cliente c , DateTime check, int num);
        Registo RemoverRegistoQuarto(int num);
        Registo AddRegistoQuarto(Quarto q,int num);
        double EfetuarPagamento(int num, double precoDia);
    }

    [Serializable]
    public class Hotel : HotelBO , IHotel
    {
        static int MAX = 100;

        #region ESTADO
        Quarto[] quartos;
        Clientes clientes;
        Empregados empregados;

        #endregion

        #region METODOS

        #region CONSTRUTORES
        /// <summary>
        /// Valores inseridos por default
        /// </summary>
        public Hotel()
        {
            quartos =new Quarto[MAX];
            clientes = new Clientes();
            empregados = new Empregados();
        }
        public Hotel(int c)
        {
            quartos = new Quarto[c];
            clientes = new Clientes();
            empregados = new Empregados();
            maxQuartos = c;
        }

        public Hotel(string a, string b,int c)
        {
            quartos = new Quarto[c];
            clientes = new Clientes();
            empregados = new Empregados();
            maxQuartos = c;
        }

        #endregion

        #region METODOS_HOTEL
        /// <summary>
        /// Guarda infos dos parametros em BO
        /// </summary>
        /// <param name="hotel"></param>
        public void GuardaInfoHotel(HotelBO hotel)
        {
            base.MaxQuartos = hotel.MaxQuartos;
            base.Morada = hotel.Morada;
            base.Nome = hotel.Nome;
            base.NumTelemovel = hotel.NumTelemovel;
        }

        public HotelBO DevolveInfo()
        {
            HotelBO hotel = new HotelBO();
            hotel.MaxQuartos = base.MaxQuartos;
            hotel.Morada = base.Morada;
            hotel.Nome = base.Nome;
            hotel.NumTelemovel = base.NumTelemovel;

            return hotel;

        }
        #endregion
        #region METODOS_QUARTO

        public Quarto FichaQuarto(int num)
        {
            if (quartos[num].Cli.NIF != 0)
            {
                return quartos[num].FichaQuarto();
            }
            else return new Quarto(); 
        }
        /// <summary>
        /// Método que faz o registo de um quarto
        /// </summary>
        /// <param name="c">Cliente</param>
        /// <param name="reserva">Dia de reserva</param>
        /// <param name="num">Numero quarto</param>
        /// <param name="add">Extras</param>
        /// <returns>Retorno do enumerador Registo</returns>
        public Registo AddRegistoQuarto(Quarto q, int num)
        {
            if (quartos[num].Reserva() == true)
            {
                if (quartos[num].Reserva(q) == true)
                {
                    return Registo.Efetuado;
                }
                else return Registo.NaoEfetuado;
            }
            else
            {
                return Registo.NaoEfetuado;
            }

        }
        /// <summary>
        /// Método que remove o registo de um quarto
        /// </summary>
        /// <param name="num">Numero do Quarto</param>
        /// <returns>Retorno do enumerador Registo</returns>
        public Registo RemoverRegistoQuarto(int num)
        {
            if (quartos[num].Reserva() == false)
            {
                quartos[num].StatusReserva(Status.NaoReservado);
                return Registo.Efetuado;
            }
            else return Registo.NaoEfetuado;
        }
        /// <summary>
        /// Método que efetua o CheckIn no hotel
        /// </summary>
        /// <param name="check">tempo da estadia</param>
        /// <param name="num">Numero do quarto</param>
        /// <returns>Booleano</returns>
        public bool EfetuarCheckIn(Cliente c, DateTime check, int num)
        {
            if (quartos[num].Reserva() == false)
            {
                if (quartos[num].CheckIn(c,check) == Check.Efetuado)
                    return true;
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// Mecanica de preços por tipo de quarto
        /// </summary>
        /// <param name="num">Numero que identifica o tipo de Quarto</param>
        /// <param name="precoDia">Preco por dia</param>
        /// <returns>Custo estadia</returns>
        public double EfetuarPagamento(int num,double precoDia)
        {
            Cliente c = quartos[num].Cli;
            double valor=quartos[num].Custo(DateTime.Today,precoDia);
            Console.WriteLine("Quarto Numero - {0} ", num);
            if (num <= maxQuartos * 0.25)
            {
                Console.WriteLine("Quarto Individual");
            }
            if (maxQuartos * 0.25<num && num <= maxQuartos * 0.50)
            {
                Console.WriteLine("Quarto Standard");
                valor = valor + 20;
            }
            if (maxQuartos * 0.50<num && num <= maxQuartos * 0.50)
            {
                Console.WriteLine("Quarto Master");
                valor = valor + 45;
            }
            if (num > maxQuartos * 0.75)
            {
                Console.WriteLine("Quarto Deluxe");
                valor = valor + 125;
            }
            c.TotalAPagar = valor;
            AddCliente(c);
            return valor;
        }

        public List<int> QuartosLivres()
        {
            int i = 0;
            List<int> quartosLivres = new List<int>();
            foreach(Quarto q in quartos)
            {
                if (q.Reserva() == true)
                {
                    quartosLivres.Add(i);
                }
                i++;
            }
            return quartosLivres;
        }
        #endregion
        #region METODOS_CLIENTE
        /// <summary>
        /// Guarda o cliente todo (objeto)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool AddCliente(Cliente c)
        {
            return clientes.GuardaCliente(c);
        }
        /// <summary>
        /// Procura cliente pelo seu numero
        /// </summary>
        /// <param name="numCliente"></param>
        /// <returns></returns>
        public Cliente ProcuraClient(int numCliente)
        {
            Cliente cli = clientes.ProcuraCliente(numCliente);
            return cli;
        }
        /// <summary>
        /// Remove cliente pelo numero
        /// </summary>
        /// <param name="numCliente"></param>
        /// <returns></returns>
        public bool RemoveCliente(int numCliente)
        {
            return clientes.RemoveCliente(numCliente);
        }
        /// <summary>
        /// Lista toda a info do cliente atraves do seu numero
        /// </summary>
        /// <param name="numCliente"></param>
        /// <returns></returns>
        public List<Cliente> FichaCliente(int numCliente)
        {
            return clientes.ListaInfo(numCliente);
        }
        #endregion
        #region METODO_EMPREGADOS
        /// <summary>
        /// Adiciona empregado todo (objeto)
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool AddEmpregado(Empregado e)
        {
            return empregados.GuardaEmpregado(e);
        }
        /// <summary>
        /// Procura empregado pelo ID Empregado
        /// </summary>
        /// <param name="idEmpregado"></param>
        /// <returns></returns>
        public Empregado ProcuraOEmpregado(int idEmpregado)
        {
            Empregado emp = empregados.ProcuraEmpregado(idEmpregado);
            return emp;
        }
        /// <summary>
        /// Remove empregado pelo ID Empregado
        /// </summary>
        /// <param name="idEmpregado"></param>
        /// <returns></returns>
        public bool RemoveEmpregado(int idEmpregado)
        {
            return empregados.RemoveEmpregado(idEmpregado);
        }
        /// <summary>
        /// Lista a info do empregado pelo ID 
        /// </summary>
        /// <param name="idEmpregado"></param>
        /// <returns></returns>
        public List<Empregado> FichaEmpregado (int idEmpregado)
        {
            return empregados.ListaInfo(idEmpregado);
        }
        #endregion
        

       
        #region DEST
        ~Hotel()
        {

        }
        #endregion

        #endregion
    }
}
