using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BO;


namespace DAO
{
   [Serializable]
    public class Empregados
    {
        #region ESTADO
        Dictionary<int, List<Empregado>> empregados = new Dictionary<int, List<Empregado>>();
        int totEmpregados;

        #endregion

        #region METODOS_CLASSE

        #region PROPRIEDADES
        /// <summary>
        /// Manipula atributo totEmpregados
        /// </summary>
        public int TotEmpregados
        {
            set { }
            get { return totEmpregados; }
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Devolve o codigo 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int GetCode(Empregado e)
        {
            return e.IDEmpregado;
        }

        /// <summary>
        /// Metodo que guarda o empregado
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool GuardaEmpregado(Empregado e)
        {

            int key = GetCode(e);
            e.InicioTrabalho = DateTime.Now;
            if (!empregados.ContainsKey(key))
            {
                empregados.Add(key, new List<Empregado> { });
                empregados[key].Add(e);
                totEmpregados++;
                Save(@"E:\Temp\Lesi 1º Ano 2º Semestre\LP2\trabalhoLP2\trabalhoLP2\Empregados.bin");
                return true;

            }
            else
            {
                empregados[key].Add(e);
                return true;
            }


        }

        /// <summary>
        /// Metodo que procura cliente pela key 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public Empregado ProcuraEmpregado(int idEmpregado)
        {
            int key = idEmpregado;
            if (empregados.ContainsKey(key) == true)
            { 
                return empregados[key][0];
            }
            else return null;

        }

        /// <summary>
        /// Metodo que remove o empregado
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool RemoveEmpregado(int idEmpregado)
        {
            int key = idEmpregado;
            empregados.Remove(key);
            totEmpregados--;
            //Como apagar o ficheiro binario que foi formado -- FAZER
            Save(@"");
            return true;
        }
        /// <summary>
        /// Lista info do empregado
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<Empregado> ListaInfo(int key)
        {
            int i = 0;
            List<Empregado> ficha = new List<Empregado>();
            foreach (Empregado emp in empregados[key])
            {
                ficha[i] = emp;
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
                bin.Serialize(stream, empregados);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                Console.Write("ERRO:" + e.Message);
                return false;
            }
        }
        #endregion
        #endregion
    }
}
