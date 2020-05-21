using BL;
using BO;
using System;
using System.Threading;
using System.Windows.Forms;

namespace TrabalhoLP2
{
    public partial class Adicionarclt : Form
    {
        Thread m1;
        public Adicionarclt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            Cliente c = new Cliente();
            if (nome.Text.Length != 0 && idade.Text.Length != 0 && nif.Text.Length != 0 && numTel.Text.Length != 0 && numC.Text.Length != 0 && numH.Text.Length != 0)
            {
                c = new Cliente(nome.Text, Int32.Parse(idade.Text), Int32.Parse(nif.Text), Int32.Parse(numTel.Text), Int32.Parse(numC.Text));
                x = ControlaClientes.AddCliente(c, Int32.Parse(numH.Text));
                
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
            try
            {
                c = new Cliente (nome.Text, Int32.Parse(idade.Text), Int32.Parse(nif.Text), Int32.Parse(numTel.Text), Int32.Parse(numC.Text)); 

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (x == false)
            {
                MessageBox.Show("Cliente " + nome.Text + " adicionado!");
                this.Hide();
            }
            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();

        }

        private void Adicionarclt_Load(object sender, EventArgs e)
        {

        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
