using System;
using System.Threading;
using System.Windows.Forms;


namespace TrabalhoLP2
{
    public partial class Gerir_Quartos : Form
    {
        Thread a4;
        Thread f1;
        Thread f2;
        Thread f3;
        Thread f4;
        Thread f5;

        public Gerir_Quartos()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
            a4 = new Thread(voltar_Menu3);
            a4.TrySetApartmentState(ApartmentState.STA);
            a4.Start();
        }
        private void voltar_Menu3(object obj)
        {
            Application.Run(new Menu());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Adicionar quarto
        private void btnadicionarqrt_Click(object sender, EventArgs e)
        {
            this.Close();
            f1 = new Thread(adicionar_Quarto);
            f1.TrySetApartmentState(ApartmentState.STA);
            f1.Start();
        }
        private void adicionar_Quarto(object obj)
        {
            Application.Run(new Adicionarqurt());
        }

        //Remover quarto
        private void btnremoverqrt_Click(object sender, EventArgs e)
        {
            this.Close();
            f2 = new Thread(remover_Quarto);
            f2.TrySetApartmentState(ApartmentState.STA);
            f2.Start();
        }
        private void remover_Quarto(object obj)
        {
            Application.Run(new Removerqurt());
        }

        //Informação quartos
        private void btninformacaoqrt_Click(object sender, EventArgs e)
        {
            this.Close();
            f3 = new Thread(informacao_Quarto);
            f3.TrySetApartmentState(ApartmentState.STA);
            f3.Start();
        }
        private void informacao_Quarto(object obj)
        {
            Application.Run(new Informacaoqurt());
        }

        //Check in quartos
        private void btncheclimqrt_Click(object sender, EventArgs e)
        {
            this.Close();
            f4 = new Thread(checkin_Quarto);
            f4.TrySetApartmentState(ApartmentState.STA);
            f4.Start();
        }
        private void checkin_Quarto(object obj)
        {
            Application.Run(new Check_In());
        }

        //Pagamento quartos
        private void btnpagamentoqrt_Click(object sender, EventArgs e)
        {
            this.Close();
            f5 = new Thread(pagamento_Quarto);
            f5.TrySetApartmentState(ApartmentState.STA);
            f5.Start();
        }
        private void pagamento_Quarto(object obj)
        {
            Application.Run(new Pagamentoqurt());
        }

        private void Gerir_Quartos_Load(object sender, EventArgs e)
        {

        }
    }
}
