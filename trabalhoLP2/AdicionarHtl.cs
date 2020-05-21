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
    public partial class AdicionarHtl : Form
    {
        Thread m1;
        public AdicionarHtl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            HotelBO hotel = new HotelBO();
            if (nome.Text.Length != 0 && codH.Text.Length != 0 && morada.Text.Length != 0 && numTel.Text.Length != 0 && numQ.Text.Length != 0) 
            {
                hotel = new HotelBO(nome.Text, morada.Text, Int32.Parse(numQ.Text),Int32.Parse(codH.Text));
                x = ControlaHoteis.AddHotel(hotel);
                MessageBox.Show("Hotel " + nome.Text + " adicionado!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
            try
            {
                hotel = new HotelBO(nome.Text, morada.Text, Int32.Parse(numQ.Text), Int32.Parse(codH.Text));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            /*
            if (!x)
            {
                MessageBox.Show("Hotel " + nome.Text + " adicionado!");
                this.Hide();
            }*/
            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();
        }

        private void AdicionarHtl_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
