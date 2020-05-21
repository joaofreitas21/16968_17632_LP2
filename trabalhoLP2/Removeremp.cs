using BL;
using System;
using System.Threading;
using System.Windows.Forms;
namespace TrabalhoLP2
{
    public partial class Removeremp : Form
    {
        Thread m1;
        public Removeremp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;

            if (codE.Text.Length != 0 && codH.Text.Length != 0)
            {
                x = ControlaEmpregados.RemoveEmpregado(Int32.Parse(codE.Text), Int32.Parse(codH.Text));
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }

            if (x)
            {
                MessageBox.Show("O empregado foi removido com sucesso.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Empregado não existe!");
            }
            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();
        }

        private void Removeremp_Load(object sender, EventArgs e)
        {

        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
