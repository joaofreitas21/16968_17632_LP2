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
using BL;
using System.Threading;

namespace TrabalhoLP2
{
    public partial class Pagamentoqurt : Form
    {
        Thread m1;
        public Pagamentoqurt()
        {
            InitializeComponent();
        }

        private void Pagamentoqurt_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
            if (numQ.Text.Length != 0 && codH.Text.Length != 0 && precoDia.Text.Length != 0)
            {
               
                MessageBox.Show("{0}",ControlaQuartos.EfetuaPagamento(Int32.Parse(numQ.Text), Int32.Parse(precoDia.Text), Int32.Parse(codH.Text)).ToString());

            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
            /*
            if (x == false)
            {
                MessageBox.Show("Cliente " + nome.Text + " adicionado!");
                this.Hide();
            }*/
            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();
        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
