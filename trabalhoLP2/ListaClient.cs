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
    public partial class ListaClient : Form
    {
        public ListaClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaClient_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            if (codC.Text.Length != 0 && codH.Text.Length != 0)
            {
                ControlaClientes.RegistoCliente(Int32.Parse(codC.Text), Int32.Parse(codH.Text));
                if (Int32.Parse(codC.Text) == c.NumeroCliente)
                {
                    dataGridView1.DataSource = ControlaEmpregados.RegistoEmpregado(Int32.Parse(codC.Text), Int32.Parse(codH.Text));
                }
                else
                {
                    MessageBox.Show("Cliente não existe!");
                }

            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
        }
    }
}
