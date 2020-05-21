using BL;
using BO;
using System;
using System.Threading;
using System.Windows.Forms;

namespace TrabalhoLP2
{
    public partial class Removerqurt : Form
    {
        Thread m1;
        public Removerqurt()
        {
            InitializeComponent();
        }

        private void Removerqurt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (codH.Text.Length != 0 && numQ.Text.Length != 0)
            {
                if(ControlaQuartos.RemoveQuarto(Int32.Parse(numQ.Text), Int32.Parse(codH.Text)) == Registo.Efetuado)
                {
                    MessageBox.Show("O quarto foi removido com sucesso.");
                }
                else
                {
                    MessageBox.Show("Quarto nao existe");
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
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
