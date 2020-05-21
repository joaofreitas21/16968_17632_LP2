using System;
using System.Threading;
using System.Windows.Forms;
using BL;
using BO;

namespace TrabalhoLP2
{
    public partial class Quartoshtl : Form
    {
        Thread m1;
        public Quartoshtl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Quartoshtl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x;

            if (codH.Text.Length != 0)
            {
                
                x = ControlaHoteis.NumQuartosLivres(Int32.Parse(codH.Text)).ToString();
                MessageBox.Show("{0} quartos livres", x);
            }
            else
            {
                  MessageBox.Show("Campos por preencher!!!");
            }
            /*
             else
             {
                   MessageBox.Show("Codigo Hotel Invalido");
             }
             */
          

            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();
        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
