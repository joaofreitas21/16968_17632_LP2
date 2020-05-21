using BL;
using BO;
using System;
using System.Threading;
using System.Windows.Forms;

namespace TrabalhoLP2
{
    public partial class Informacaoclt : Form
    {
        Thread m1;
        public Informacaoclt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            if (numC.Text.Length != 0 && numH.Text.Length != 0)
            {
                ControlaClientes.GetCliente(Int32.Parse(numC.Text), Int32.Parse(numH.Text));
                if (Int32.Parse(numC.Text) == c.NumeroCliente)
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
            }
            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();




        }

        private void Informacaoclt_Load(object sender, EventArgs e)
        {

        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
