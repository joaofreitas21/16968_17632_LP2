﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BO;


namespace DAO
{
    [Serializable]
    public class Clientes 
    {
        #region ESTADO
        Dictionary<int, List<Cliente>> clientes;
        int totalClientes;
        #endregion

        #region METODOS
        #region CONSTRUTORES
        /// <summary>
        /// Construtor Clientes
        /// </summary>
        public Clientes()
        {
            clientes = new Dictionary<int, List<Cliente>>();
            totalClientes = 0;
        }
        #endregion

        #region PROPRIEDADES
        /// <summary>
        /// Manipula o atributo total clientes
        /// </summary>
        public int TotalClientes
        {
            set { }
            get { return totalClientes; }
        }

        #endregion
        #region METODOS_CLASSE
        /// <summary>
        /// Devolve o codigo 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int GetCode(Cliente c)
        {
            return c.NumeroCliente;
        }

        /// <summary>
        /// Metodo que guarda o cliente 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool GuardaCliente(Cliente c)
         {

            int key = GetCode(c);
            c.DataRegisto = DateTime.Now;
            if (!clientes.ContainsKey(key))
            {
                clientes.Add(key, new List<Cliente> { });
                clientes[key].Add(c);
                totalClientes++;
                Save(@"E:\Temp\Lesi 1º Ano 2º Semestre\LP2\trabalhoLP2\trabalhoLP2\Clientes.bin");
                return true;

            }
            else
            {
                clientes[key].Add(c);
                return true;
            }
           
            
        }

        /// <summary>
        /// Metodo que procura cliente pela key 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public Cliente ProcuraCliente(int numCliente)
        {
            int key = numCliente;
            if (clientes.ContainsKey(key) == true)
            {
                return clientes[key][0];
            }
            else return null;

        }
        /// <summary>
        /// Metodo que remove o cliente da hashtable
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool RemoveCliente(int numCliente)
        {
            int key = numCliente;
            clientes.Remove(key);
            totalClientes--;
            //Como apagar o ficheiro binario que foi formado -- FAZER
            Save(@"");
            return true;
        }

        public List<Cliente> ListaInfo(int key)
        {
            int i = 0;
            List<Cliente> ficha = new List<Cliente>();
            foreach(Cliente cl in clientes[key])
            {
                ficha[i] = cl;
                i++;
            }
            return ficha;
        }
        /// <summary>
        /// Save Formato - msdn
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool Save(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, clientes);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                Console.Write("ERRO:" + e.Message);
                return false;
            }
        }

        /*
         LOAD MAYBE!
         */

        #endregion
        #region DEST
        ~Clientes()
        {

        }
        #endregion

        #endregion
    }
}
