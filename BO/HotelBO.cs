using System;

namespace BO
{
   [Serializable]
    public class HotelBO
    {
        static int MAX = 100;

        #region ESTADO
        string nome;
        string morada;
        int numTlm;
        int cod;
        protected int maxQuartos;

        #endregion

        #region METODOS

        #region CONSTRUTORES
        /// <summary>
        /// Valores inseridos por default
        /// </summary>
        public HotelBO()
        {
            nome = "";
            morada = "";
            maxQuartos = 0;
        }
        
        public HotelBO(string a, string b,int c)
        {
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
        public int NumTelemovel
        {
            get { return numTlm; }
            set { numTlm = value; }
        }
        public int Cod
        {
            get { return cod; }
            set
            {
                if (value > 0) maxQuartos = value;
            }
           
        }
        public override string ToString()
        {
            return string.Format("Nome= {0} \nMorada= {1} \nTelemovel= {2} \nQuantidade de Quartos= {3}", Nome, morada, numTlm, maxQuartos);
        }
        #endregion

        #region DEST
        ~HotelBO()
        {

        }
        #endregion

        #endregion
    }
}
