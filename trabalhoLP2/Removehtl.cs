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
using BO;

namespace TrabalhoLP2
{
    public partial class Removehtl : Form
    {
        public Removehtl()
        {
            InitializeComponent();
        }

        private void Removehtl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;

            if (codH.Text.Length != 0 )
            {
                x = ControlaHoteis.RemoveHotel(Int32.Parse(codH.Text));
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }

            if (x)
            {
                MessageBox.Show("O hotel foi removido com sucesso.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hotel não existe!");
            }
        }
    }
}
