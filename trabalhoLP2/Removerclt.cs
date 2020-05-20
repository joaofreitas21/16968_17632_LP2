using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLP2
{
    public partial class Removerclt : Form
    {
        public Removerclt()
        {
            InitializeComponent();
        }

        private void Removerclt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;

            if (codC.Text.Length != 0 && codH.Text.Length != 0)
            {
                x = ControlaClientes.RemoveCliente(Int32.Parse(codC.Text), Int32.Parse(codH.Text));
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }

            if (x)
            {
                MessageBox.Show("O cliente foi removido com sucesso.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cliente não existe!");
            }
        }
    }
}
