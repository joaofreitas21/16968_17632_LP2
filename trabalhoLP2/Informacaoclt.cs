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
    public partial class Informacaoclt : Form
    {
        public Informacaoclt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            if (numC.Text.Length != 0 && numH.Text.Length != 0)
            {
                ControlaClientes.GetCliente(Int32.Parse(numC.Text), Int32.Parse(numH.Text));
                if (Int32.Parse(numC.Text) == c.NumeroCliente)
                {
                    MessageBox.Show("Cliente Encontrado");
                    this.Hide();
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

        private void Informacaoclt_Load(object sender, EventArgs e)
        {

        }
    }
}
