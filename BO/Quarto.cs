using System;

namespace BO
{
    [Serializable]
    public class Quarto: IQ
    {
        #region ESTADO
        Status status;
        Cliente cli;
        DateTime reserva;
        Adicoes adicoes;
        Check check;

        #endregion

        #region METODOS
        #region CONSTRUTORES
        public Quarto()
        {
            status = Status.NaoReservado;
            cli = new Cliente();
        }
        public Quarto(Cliente p, DateTime reserva)
        {
            cli = p;
            this.reserva = reserva;
            status = Status.Reservado;
        }
        #endregion
        #region PROPRIEDADES
        public Cliente Cli
        {
            get { return cli; }
            set { if (cli.NIF == 0) cli = value; }
        }
        public DateTime ReservaAux
        {
            get { return reserva; }
            set
            {
                if (status == Status.NaoReservado)
                    reserva = value;
            }
        }
        public Adicoes Adicoes
        {
            get { return adicoes; }
            set
            {
                if (status == Status.NaoReservado)
                    adicoes = value;
            }
        }
        #endregion

        #region METODOS_CLASSE

        /// <summary>
        /// Verifica se o quarto está reservado
        /// </summary>
        /// <returns>booleano</returns>
        public bool Reserva()
        {
            if (status == Status.NaoReservado)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Metodo que devolve se a reserva foi bem sucedida
        /// </summary>
        /// <param name="p"></param>
        /// <param name="Reserva"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public bool Reserva(Quarto q)
        {
            if (cli.NIF != 0 && status==Status.NaoReservado)
            {
                this.cli = q.Cli;
                this.reserva = q.ReservaAux;
                this.adicoes = q.Adicoes;
                status = Status.Reservado;
  
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool StatusReserva(Status stat)
        {
            status = stat;
            return true;
        }
        /// <summary>
        /// Metodo que efetua checkin
        /// </summary>
        /// <param name="chegada">Checkin efetuado com desvio de 1h</param>
        /// <returns>Se foi efetuado/nao efetuado</returns>
        public Check CheckIn(Cliente cliente, DateTime chegada)
        {
            if (cli.NIF == cliente.NIF && status == Status.Reservado && check == Check.NaoEfetuado)
            {
                if (chegada.Hour <= reserva.Hour - 1 && chegada.Date == reserva.Date)
                {
                    check = Check.Efetuado;
                    return check;
                }
                else
                {
                    status = Status.NaoReservado;
                    return check;
                }
            } else{
                
                return check;
            }
        }
        /// <summary>
        /// Calculo do custo
        /// </summary>
        /// <param name="fim">Dia de checkout</param>
        /// <param name="precoDia">Preço ao dia</param>
        /// <returns></returns>
        public double Custo(DateTime fim,double precoDia)
        {
            double valor = cli.TotalPagar(fim, reserva,precoDia,adicoes);
            status = Status.NaoReservado;
            return valor;
        }
        
        public Quarto FichaQuarto()
        {
            Quarto quarto = new Quarto();
            quarto.Cli = this.Cli;
            quarto.ReservaAux = this.ReservaAux;
            quarto.Adicoes = this.Adicoes;
            return quarto;
        }
        #endregion


        #region OVERRIDES
        public override string ToString()
        {
            return string.Format("\nReserva= {0} \nAdcioes= {1} \nStatus= {2}", reserva, Adicoes, status);
        }
        #endregion
        #region DEST
        ~Quarto()
        {

        }
        #endregion
        #endregion
    }
}
