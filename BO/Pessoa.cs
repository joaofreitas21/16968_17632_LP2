using System;

namespace BO
{
    public class Pessoa
    {
        #region ESTADO
        int idade;
        string nome;
        int numTlmv;
        DateTime dataNasc;
        protected int nif;
        #endregion

        #region METODOS

        #region CONSTRUTORES
        

        /// <summary>
        /// Construtor com valores por defeito/omissão
        /// </summary>
        public Pessoa()
        {
            idade = -1;
            nome = "";
        }

        
        public Pessoa(int idade, string nome,int nif)
        {
            this.idade = idade;
            this.nome = nome;
            this.nif = nif;
        }

        #endregion

        #region PROPRIEDADES
     

        /// <summary>
        /// Manipula o atributo "idade"
        /// int idade;
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { if (value > 0) idade = value; }
        }

        public int NumTelemovel
        {
            get { return numTlmv; }
            set { numTlmv = value; }
        }
        /// <summary>
        /// Manipula o atributo "nome"
        /// string nome;
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        /// <summary>
        /// Define data de Nascimento
        /// </summary>
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataNasc = aux;
                }
            }
        }
        /// <summary>
        /// Manipula o atributo nif & valida se foi inserido corretamente
        /// </summary>
        public int NIF
        {
            get { return nif; }
            set
            {
                if (value > 0 && (value.ToString()).Length == 9)
                {
                   nif = value;
                }
            }
        }

        #endregion

        #region OPERATORS
        public static bool operator ==(Pessoa x, Pessoa y)
        {
            return (x.Equals(y));
        }

        public static bool operator !=(Pessoa x, Pessoa y)
        {
            return (!(x == y));
        }
        #endregion

        #region OVERRIDES

        public override bool Equals(Object obj)
        {
            Pessoa aux = (Pessoa)obj;
            return (this.nome == aux.nome && aux.nif == this.nif ? true:false);
        }

        public override string ToString()
        {
            return string.Format("Nome= {0} - Idade= {1}", Nome, Idade);
        }
        #endregion

        #region DEST
       
        ~Pessoa()
        {

        }
        #endregion

        #endregion

    }
}
