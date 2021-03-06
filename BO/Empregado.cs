﻿using System;

namespace BO
{
   [Serializable]
    public class Empregado : Pessoa
    {
        #region ESTADO
        TipoTrabalho trabalho;
        DateTime inicioTrabalho;
        string morada;
        double vencimento;
        int idEmpregado=0;
        DateTime atualizacao;

        #endregion

        #region METODOS

        #region CONSTRUTORES
        /// <summary>
        /// Valores inseridos por default
        /// </summary>
        public Empregado() : base()
        {
            inicioTrabalho = DateTime.Parse("01/01/2020");
            vencimento = 0;
            morada = "";
            trabalho = TipoTrabalho.Limpeza;
        }
       
        public Empregado(string n,int i,int nif,float venc,int numTel,int idEmpregado) : base(i, n, nif)
        {
            vencimento = venc;
        }

        #endregion

        #region PROPRIEDADES
        public DateTime InicioTrabalho
        {
            get { return inicioTrabalho; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    inicioTrabalho = value;
                }
            }
        }
        public DateTime Atualizacao
        {
            get { return atualizacao; }
            set
            {
                
                if (atualizacao == null) atualizacao = value;
                
            }
        }
        /// <summary>
        /// Manipula o atributo morada
        /// </summary>
        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }
        /// <summary>
        /// Manipula o atributo trabalho
        /// </summary>
        public TipoTrabalho Trabalho
        {
            get { return trabalho; }
            set { trabalho = value; }
        }
        public int IDEmpregado
        {
            get { return idEmpregado; }
            set { if (idEmpregado == 0) idEmpregado = value; }
        }
        /// <summary>
        /// Definir ordenado conforme tipo de trabalho
        /// </summary>
        public double Vencimento
        {
            get {
                if (CodPessoa() == true)
                {
                    return vencimento;
                }
                else
                {
                    Console.WriteLine("Codigo Incorreto");
                    return 0000;
                }
            }
            set {
                vencimento = value - value * 0.23;
                switch (trabalho)
                {
                    case TipoTrabalho.Limpeza:
                        {
                            vencimento = vencimento + 25;
                            break;
                        }
                    case TipoTrabalho.Bar:
                        {
                            vencimento = vencimento + 50;
                            break;
                        }
                    case TipoTrabalho.Rececao:
                        {
                            vencimento = vencimento + 250;
                            break;
                        }
                    case TipoTrabalho.Seguranca:
                        {
                            vencimento = vencimento + 100;
                            break;
                        }
                    case TipoTrabalho.Staff:
                        {
                            vencimento = vencimento +  value * 0.75;
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Booleano para verificar o codigo pessoal
        /// </summary>
        /// <returns></returns>
        private bool CodPessoa()
        {
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == base.nif)
            {
                return true;
            }
            else return false;
        }

        #endregion
        #region DEST
        ~Empregado()
        {

        }
        #endregion
        #endregion
    }
}
