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
using TrabalhoLP2.Clientes;

namespace TrabalhoLP2
{
 
    public partial class Gerir_Clientes : Form
    {
        Thread a1;//voltar de gerir clientes para menu
        Thread c1;//Gerir clientes para adicionar cliente
        Thread c2;//Gerir clientes para remover cliente
        Thread c3;//Gerir clientes para informação cliente
        Thread c4;//Gerir clientes para Registo cliente

        public Gerir_Clientes()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
            a1 = new Thread(voltar_Menu2);
            a1.TrySetApartmentState(ApartmentState.STA);
            a1.Start();
        }
        private void voltar_Menu2(object obj)
        {
            Application.Run(new Menu());
        }

        //Adicionar cliente
        private void btnadicionarclt_Click(object sender, EventArgs e)
        {
            this.Close();
            c1 = new Thread(adicionar_Cliente);
            c1.TrySetApartmentState(ApartmentState.STA);
            c1.Start();
        }
        private void adicionar_Cliente(object obj)
        {
            Application.Run(new Adicionarclt());
        }

        //remover cliente
        private void btnremoverclt_Click(object sender, EventArgs e)
        {
            this.Close();
            c2 = new Thread(remover_Cliente);
            c2.TrySetApartmentState(ApartmentState.STA);
            c2.Start();
        }
        private void remover_Cliente(object obj)
        {
            Application.Run(new Removerclt());
        }

        //Informação Cliente
        private void btninformacaoclt_Click(object sender, EventArgs e)
        {
            this.Close();
            c3 = new Thread(informacao_Cliente);
            c3.TrySetApartmentState(ApartmentState.STA);
            c3.Start();
        }
        private void informacao_Cliente(object obj)
        {
            Application.Run(new Informacaoclt());
        }

        //Registo cliente
        private void btnregistoclt_Click(object sender, EventArgs e)
        {
            this.Close();
            c4 = new Thread(registo_Cliente);
            c4.TrySetApartmentState(ApartmentState.STA);
            c4.Start();
        }
        private void registo_Cliente(object obj)
        {
            Application.Run(new Registoclt());
        }
    }
}
