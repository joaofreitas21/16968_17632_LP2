using System;
using System.Threading;
using System.Windows.Forms;

namespace TrabalhoLP2
{
    public partial class Informacaoqurt : Form
    {
        Thread m1;
        public Informacaoqurt()
        {
            InitializeComponent();
        }

        private void Informacaoqurt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Quarto q = new Quarto();
            if (codQ.Text.Length != 0 && codH.Text.Length != 0)
            {
                ControlaQuartos.InfoQuarto(Int32.Parse(codQ.Text), Int32.Parse(codH.Text));
                if (Int32.Parse(codQ.Text) == q.Cli)
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
