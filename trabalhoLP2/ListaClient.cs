using BL;
using BO;
using System;
using System.Threading;
using System.Windows.Forms;
namespace TrabalhoLP2
{
    public partial class ListaClient : Form
    {
        Thread m1;
        public ListaClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaClient_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            if (codC.Text.Length != 0 && codH.Text.Length != 0)
            {
                ControlaClientes.RegistoCliente(Int32.Parse(codC.Text), Int32.Parse(codH.Text));
                if (Int32.Parse(codC.Text) == c.NumeroCliente)
                {
                    dataGridView1.DataSource = ControlaClientes.RegistoCliente(Int32.Parse(codC.Text), Int32.Parse(codH.Text));
                }
                else
                {
                    MessageBox.Show("Cliente não existe!");
                }

            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
