using System;

namespace trabalhoLP2
{
    enum Registo
    {
        Efetuado,
        NaoEfetuado,
    }
    class Hotel:IHotel
    {
        static int MAX = 100;

        #region ESTADO
        Quarto[] quartos;
        string nome;
        string morada;
        int maxQuartos;

        #endregion

        #region METODOS

        #region CONSTRUTORES
        /// <summary>
        /// Valores inseridos por default
        /// </summary>
        public Hotel()
        {
            quartos =new Quarto[MAX];
            nome = "";
            morada = "";
            maxQuartos = 0;
        }
        
        public Hotel(string a, string b,int c)
        {
            quartos = new Quarto[c];
            nome = a;
            morada = b;
            maxQuartos = c;
        }

        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipula o atributo nome do hotel
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Manipula o atributo morada do hotel
        /// </summary>
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }
        /// <summary>
        /// Manipula o atributo maxQuartos do hotel
        /// </summary>
        public int MaxQuartos
        {
            get { return maxQuartos; }
            set { if (value > 0) maxQuartos = value; }
        }


        #endregion
        #region METODOS_CLASSE


        /// <summary>
        /// Método que faz o registo de um quarto
        /// </summary>
        /// <param name="c">Cliente</param>
        /// <param name="reserva">Dia de reserva</param>
        /// <param name="num">Numero quarto</param>
        /// <param name="add">Extras</param>
        /// <returns>Retorno do enumerador Registo</returns>
        public Registo AddRegistoQuarto(Cliente c,string reserva,int num,Adicoes add)
        {
            if (quartos[num].Reserva() == true)
            {
                quartos[num].Reserva(c, reserva,add);
                return Registo.Efetuado;
                
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
                quartos[num] = new Quarto();
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
        public bool EfetuarCheckIn(string check,int num)
        {
            if (quartos[num].Reserva() == false)
            {
                if (quartos[num].CheckIn(check) == Check.Efetuado)
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
            return valor;
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
