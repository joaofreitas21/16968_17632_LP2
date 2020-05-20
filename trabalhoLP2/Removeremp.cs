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
    public partial class Removeremp : Form
    {
        public Removeremp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;

            if (codE.Text.Length != 0 && codH.Text.Length != 0)
            {
                x = ControlaEmpregados.RemoveEmpregado(Int32.Parse(codE.Text), Int32.Parse(codH.Text));
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }

            if (x)
            {
                MessageBox.Show("O empregado foi removido com sucesso.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Empregado não existe!");
            }
        }

        private void Removeremp_Load(object sender, EventArgs e)
        {

        }
    }
}
