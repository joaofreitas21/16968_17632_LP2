using BL;
using System;
using System.Threading;
using System.Windows.Forms;

namespace TrabalhoLP2
{
    public partial class Removerclt : Form
    {
        Thread m1;
        public Removerclt()
        {
            InitializeComponent();
        }

        private void Removerclt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;

            if (codC.Text.Length != 0 && codH.Text.Length != 0)
            {
                x = ControlaClientes.RemoveCliente(Int32.Parse(codC.Text), Int32.Parse(codH.Text));
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }

            if (x)
            {
                MessageBox.Show("O cliente foi removido com sucesso.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cliente não existe!");
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
