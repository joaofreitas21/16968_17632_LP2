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
    public partial class Informacaoqurt : Form
    {
        public Informacaoqurt()
        {
            InitializeComponent();
        }

        private void Informacaoqurt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Quarto q = new Quarto();
            if (codQ.Text.Length != 0 && codH.Text.Length != 0)
            {
                ControlaQuartos.InfoQuarto(Int32.Parse(codQ.Text), Int32.Parse(codH.Text));
                if (Int32.Parse(codQ.Text) == q.Cli)
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
            }*/
        }
    }
}
