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
    public partial class Menu : Form
    {
        Thread t2;
        Thread t3;
        Thread t4;
        Thread t5;
        Thread t6;
        public Menu()
        {
            InitializeComponent();
        }
        //ir de menu para gerir hotel
        private void btnHotel_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(abrir_Hotel);
            t2.TrySetApartmentState(ApartmentState.STA);
            t2.Start();
        }
        private void abrir_Hotel(object obj)
        {
            Application.Run(new Gerir_Hotel());
        }

        //ir de menu para gerir cliente
        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(abrir_Cliente);
            t3.TrySetApartmentState(ApartmentState.STA);
            t3.Start();
        }
        private void abrir_Cliente(object obj)
        {
            Application.Run(new Gerir_Clientes());
        }

        //ir de menu para gerir empregados
        private void btnempregados_Click(object sender, EventArgs e)
        {
            this.Close();
            t4 = new Thread(abrir_Empregados);
            t4.TrySetApartmentState(ApartmentState.STA);
            t4.Start();
        }
        private void abrir_Empregados(object obj)
        {
            Application.Run(new Gerir_Empregados());
        }

        //ir de menu para gerir quartos
        private void btnquartos_Click(object sender, EventArgs e)
        {
            this.Close();
            t5 = new Thread(abrir_Quarto);
            t5.TrySetApartmentState(ApartmentState.STA);
            t5.Start();
        }
        private void abrir_Quarto(object obj)
        {
            Application.Run(new Gerir_Quartos());
        }

        //Voltar de menu para Login
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            t6 = new Thread(voltar_Login);
            t6.TrySetApartmentState(ApartmentState.STA);
            t6.Start();
        }
        private void voltar_Login(object obj)
        {
            Application.Run(new Login());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
