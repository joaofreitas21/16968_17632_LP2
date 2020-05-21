using BL;
using System;
using System.Threading;
using System.Windows.Forms;

namespace TrabalhoLP2
{
    public partial class Removehtl : Form
    {
        Thread m1;
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
