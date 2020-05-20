using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace TrabalhoLP2
{
    public partial class Gerir_Empregados : Form
    {
        Thread a2;
        Thread d1;
        Thread d2;
        Thread d3;
        Thread d4;

        public Gerir_Empregados()
        {
            InitializeComponent();
        }

        //voltar para menu
        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
            a2 = new Thread(voltar_Menu1);
            a2.TrySetApartmentState(ApartmentState.STA);
            a2.Start();
        }
        private void voltar_Menu1(object obj)
        {
            Application.Run(new Menu());
        }

        //adicionar empregados
        private void btnadicionaremp_Click(object sender, EventArgs e)
        {
            this.Close();
            d1 = new Thread(adicionar_Empregados);
            d1.TrySetApartmentState(ApartmentState.STA);
            d1.Start();
        }
        private void adicionar_Empregados(object obj)
        {
            Application.Run(new Adicionaremp());
        }

        //Remover Empregados
        private void btnremoveremp_Click(object sender, EventArgs e)
        {
            this.Close();
            d2 = new Thread(remover_Empregados);
            d2.TrySetApartmentState(ApartmentState.STA);
            d2.Start();
        }
        private void remover_Empregados(object obj)
        {
            Application.Run(new Removeremp());
        }

        //Informação Empregados
        private void btninformacaoemp_Click(object sender, EventArgs e)
        {
            this.Close();
            d3 = new Thread(informacao_Empregados);
            d3.TrySetApartmentState(ApartmentState.STA);
            d3.Start();
        }
        private void informacao_Empregados(object obj)
        {
            Application.Run(new Informaçãoemp());
        }

        //Registo cliente
        private void btnregistoemp_Click(object sender, EventArgs e)
        {
            this.Close();
            d4 = new Thread(registo_Empregados);
            d4.TrySetApartmentState(ApartmentState.STA);
            d4.Start();
        }
        private void registo_Empregados(object obj)
        {
            Application.Run(new ListaEmp());
        }

        private void Gerir_Empregados_Load(object sender, EventArgs e)
        {

        }
    }
}
