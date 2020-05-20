using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BO;

namespace TrabalhoLP2
{
    public partial class Informaçãoemp : Form
    {
        public Informaçãoemp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empregado emp = new Empregado();
            if (codE.Text.Length != 0 && codH.Text.Length != 0)
            {
                ControlaEmpregados.GetEmpregado(Int32.Parse(codE.Text), Int32.Parse(codH.Text));
                if (Int32.Parse(codE.Text) == emp.IDEmpregado)
                {
                    MessageBox.Show("Empregado Encontrado");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Empregado não existe!");
                }

            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
        }

        private void Informaçãoemp_Load(object sender, EventArgs e)
        {

        }
    }
}
