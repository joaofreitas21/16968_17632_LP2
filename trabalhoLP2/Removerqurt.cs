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
    public partial class Removerqurt : Form
    {
        public Removerqurt()
        {
            InitializeComponent();
        }

        private void Removerqurt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (codH.Text.Length != 0 && numQ.Text.Length != 0)
            {
                if(ControlaQuartos.RemoveQuarto(Int32.Parse(numQ.Text), Int32.Parse(codH.Text)) == Registo.Efetuado)
                {
                    MessageBox.Show("O quarto foi removido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Quarto nao existe");
                }
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }

            
        }
    }
}
