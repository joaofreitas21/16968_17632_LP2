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
    public partial class Check_In : Form
    {
        Thread m1;
        public Check_In()
        {
            InitializeComponent();
        }

        private void Check_In_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataCheck_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dataCheckIn = DateTime.Parse(dataCheck.Text);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                MessageBox.Show("{0}", ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            Cliente cli = new Cliente();
            if (numQ.Text.Length != 0 && codC.Text.Length != 0 && codH.Text.Length != 0)
            {
                cli.NumeroCliente = Int32.Parse(codC.Text);
                x = ControlaQuartos.EfetuarCheckIn(cli,Convert.ToDateTime(dataCheck.Text), Int32.Parse(numQ.Text), Int32.Parse(codH.Text));

            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }

            if (x == false)
            {
                MessageBox.Show("CheckIn efetuado!");
                this.Hide();
            }
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
