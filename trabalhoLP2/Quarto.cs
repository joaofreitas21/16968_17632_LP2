using System;

namespace DAO
{
    enum Adicoes
    {
        LimpezaDiaria=10,
        Bar=12,
    }
    enum Status
    {
        Reservado,
        NaoReservado
    }
    enum Check
    {
        Efetuado=1,
        NaoEfetuado=-1
    }
    class Quarto:IQ
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
        public Quarto(Cliente p, string a)
        {
            cli = p;
            reserva = DateTime.Parse(a);
            status = Status.Reservado;
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
        public bool Reserva(Cliente p,string reserva,Adicoes add)
        {
            if (cli.NIF != 0 && status==Status.NaoReservado)
            {
                cli = p;
                DateTime.TryParse(reserva,out this.reserva);
                
                status= Status.Reservado;
                adicoes = add;
                return true;
            }
            else
            {
                return false;
            }
            
        }
        /// <summary>
        /// Metodo que efetua checkin
        /// </summary>
        /// <param name="chegada">Checkin efetuado com desvio de 1h</param>
        /// <returns>Se foi efetuado/nao efetuado</returns>
        public Check CheckIn(string chegada)
        {
            DateTime cheg = DateTime.Parse(chegada);
            if (cheg.Hour <= reserva.Hour - 1)
            {
                check = Check.Efetuado;
                return check;
            }
            else
            {
                return Check.NaoEfetuado;
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
            return cli.TotalPagar(fim, reserva,precoDia,adicoes);
        }
        
        public Cliente CliReservado()
        {
            return cli;
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
