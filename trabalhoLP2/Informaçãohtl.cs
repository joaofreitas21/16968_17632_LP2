﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BO;

namespace TrabalhoLP2
{
  
    public partial class Informaçãohtl : Form
    {
        Thread m1;
        public Informaçãohtl()
        {
            InitializeComponent();
        }

        private void Informaçãohtl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotelBO h = new HotelBO();
            if (codH.Text.Length != 0)
            {
                ControlaHoteis.InfoHotel(Int32.Parse(codH.Text));
                if (Int32.Parse(codH.Text) == h.Cod)
                {
                    MessageBox.Show("Hotel Encontrado");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hotel não existe!");
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
