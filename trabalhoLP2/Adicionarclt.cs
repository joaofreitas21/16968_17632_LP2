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
    public partial class Adicionarclt : Form
    {
        public Adicionarclt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            Cliente c = new Cliente();
            if (nome.Text.Length != 0 && idade.Text.Length != 0 && nif.Text.Length != 0 && numTel.Text.Length != 0 && numC.Text.Length != 0 && numH.Text.Length != 0)
            {
                c = new Cliente(nome.Text, Int32.Parse(idade.Text), Int32.Parse(nif.Text), Int32.Parse(numTel.Text), Int32.Parse(numC.Text));
                x = ControlaClientes.AddCliente(c, Int32.Parse(numH.Text));
                
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
            try
            {
                c = new Cliente (nome.Text, Int32.Parse(idade.Text), Int32.Parse(nif.Text), Int32.Parse(numTel.Text), Int32.Parse(numC.Text)); 

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (x == false)
            {
                MessageBox.Show("Cliente " + nome.Text + " adionado!");
                this.Hide();
            }
            
        }

        private void Adicionarclt_Load(object sender, EventArgs e)
        {

        }
    }
}
