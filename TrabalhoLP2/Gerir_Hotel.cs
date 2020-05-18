﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TrabalhoLP2.Hotel;

namespace TrabalhoLP2
{
    public partial class Gerir_Hotel : Form
    {
        Thread a3;//voltar de gerir hotel para menu
        Thread b1;//Gerir hotel para adicionar hotel
        Thread b2;//Gerir Hotel para remover hotel
        Thread b3;//Gerir Hotel para informação hotel
        Thread b4;//Gerir hotel para quartos livres
        public Gerir_Hotel()
        {
            InitializeComponent();
        }

        //voltar para menu
        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
            a3 = new Thread(voltar_Menu);
            a3.TrySetApartmentState(ApartmentState.STA);
            a3.Start();
        }
        private void voltar_Menu(object obj)
        {
            Application.Run(new Menu());
        }

        //Adicionar hotel
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            this.Close();
            b1 = new Thread(adicionar_Hotel);
            b1.TrySetApartmentState(ApartmentState.STA);
            b1.Start();
        }
        private void adicionar_Hotel(object obj)
        {
            Application.Run(new AdicionarHtl());
        }

        //Remover Hotel
        private void btnremover_Click(object sender, EventArgs e)
        {
            this.Close();
            b2 = new Thread(remover_Hotel);
            b2.TrySetApartmentState(ApartmentState.STA);
            b2.Start();
        }
        private void remover_Hotel(object obj)
        {
            Application.Run(new Removehtl());
        }

        //Informação Hotel
        private void btninformacao_Click(object sender, EventArgs e)
        {
            this.Close();
            b3 = new Thread(informacao_Hotel);
            b3.TrySetApartmentState(ApartmentState.STA);
            b3.Start();
        }
        private void informacao_Hotel(object obj)
        {
            Application.Run(new Informaçãohtl());
        }

        //Quartos livres hotel
        private void btnquartos_Click(object sender, EventArgs e)
        {
            this.Close();
            b4 = new Thread(quartos_Hotel);
            b4.TrySetApartmentState(ApartmentState.STA);
            b4.Start();
        }
        private void quartos_Hotel(object obj)
        {
            Application.Run(new Quartoshtl());
        }
    }
}
