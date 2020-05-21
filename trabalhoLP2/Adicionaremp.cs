using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BL;
using System.Threading;

namespace TrabalhoLP2
{
    public partial class Adicionaremp : Form
    {
        Thread m1;
        public Adicionaremp()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime inicioContrato = DateTime.Parse(date.Text);
            }
            catch(Exception ex)
            {
                //throw new Exception(ex.Message);
                MessageBox.Show("{0}",ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            Empregado emp = new Empregado();
            if (nome.Text.Length != 0 && idade.Text.Length != 0 && nif.Text.Length != 0 && numTel.Text.Length != 0 && codE.Text.Length != 0 && venc.Text.Length != 0 &&codH.Text.Length != 0)
            {
                emp = new Empregado(nome.Text, Int32.Parse(idade.Text), Int32.Parse(nif.Text), Int32.Parse(venc.Text), Int32.Parse(numTel.Text), Int32.Parse(codE.Text));
                x = ControlaEmpregados.AddEmpregado(emp, Int32.Parse(codE.Text));
                
            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
            try
            {
                emp = new Empregado(nome.Text, Int32.Parse(idade.Text), Int32.Parse(nif.Text), Int32.Parse(venc.Text), Int32.Parse(numTel.Text), Int32.Parse(codE.Text));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (x == false)
            {
                MessageBox.Show("Empregado " + nome.Text + " adicionado!");
                this.Hide();
            }
            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();
        }

        private void Adicionaremp_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.tipoT.Items;

            collection.Add("Rececao");
            collection.Add("Bar");
            collection.Add("Staff");
            collection.Add("Limpeza");
            collection.Add("Seguranca");

            this.tipoT.Text = "Limpeza";
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
