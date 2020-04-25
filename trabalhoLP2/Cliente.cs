using System;

namespace trabalhoLP2
{
    class Cliente:Pessoa
    {
        #region ESTADO
        int numeroCliente;
        double totalPagar;
        DateTime dataRegisto;
        #endregion

        #region METODOS
        #region CONSTRUTORES
        /// <summary>
        /// Dados inseridos por default
        /// </summary>
        public Cliente() : base()
        {
            numeroCliente = 0;
            totalPagar = 0;
        }
    
        public Cliente(int idade,string nome,int nif,int num) : base(idade,nome,nif)
        {
            numeroCliente = num;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipula o atributo numero cliente
        /// </summary>
        public int NumeroCliente
        {
            get { return numeroCliente; }
            set { numeroCliente = value; }
        }

        /// <summary>
        /// Colocar a data do registo
        /// </summary>
        public DateTime DataRegisto
        {
            get { return dataRegisto; }
            set
            {
                if (dataRegisto == null)
                    dataRegisto = value;
            }
         }
        
        #endregion

        #region OVERRIDES

        public override bool Equals(Object obj)
        {
            Cliente aux = (Cliente)obj;
            return (this.numeroCliente == aux.numeroCliente? true : false);
        }
        #endregion
        #region OPERADORES
        public static bool operator ==(Cliente x, Cliente y)
        {
            return (x.Equals(y));
        }

        public static bool operator !=(Cliente x, Cliente y)
        {
            return (!(x == y));
        }
        #endregion
        #region METODOS_CLASSE
        /// <summary>
        /// Obter o total a pagar
        /// </summary>
        /// <param name="fim">Dia do Checkout</param>
        /// <param name="reserva">Inicio da estadia</param>
        /// <param name="precoDia">Preço por dia</param>
        /// <param name="add">Serviços extra</param>
        /// <returns></returns>
        public double TotalPagar(DateTime fim, DateTime reserva, double precoDia, Adicoes add)
        {
            int tempo;
            tempo = fim.Day - reserva.Day;
            //preço sem extras
            totalPagar=(precoDia * tempo);
            //cast
            return (totalPagar + (int)add * tempo);
        }

        #endregion
        #region DEST
        ~Cliente()
        {

        }
        #endregion
#endregion
    }
}
