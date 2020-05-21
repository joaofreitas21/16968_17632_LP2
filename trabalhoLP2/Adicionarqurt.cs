using System;
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
    public partial class Adicionarqurt : Form
    {
        Thread m1;
        public Adicionarqurt()
        {
            InitializeComponent();
        }

        private void Adicionarqurt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = false;
            Quarto q = new Quarto();
            Cliente c = new Cliente();
            if (codH.Text.Length != 0 && numQ.Text.Length != 0 && numC.Text.Length != 0 && extra.Text.Length != 0 )
            {
                c.NumeroCliente = Int32.Parse(numC.Text);
                q = new Quarto(c,Convert.ToDateTime(fimR.Text));
                x = ControlaQuartos.AddQuarto(q, Int32.Parse(numQ.Text),Int32.Parse(codH.Text));

            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
            try
            {
                q = new Quarto(c, Convert.ToDateTime(fimR));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (x == false)
            {
                MessageBox.Show("Reserva ao quarto " + codH.Text + " adicionada!");
                this.Hide();
            }
            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();

        }

        private void extra_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox extra = new ComboBox();
            extra.Items.Add("Limpeza Diaria");
            extra.Items.Add("Bar");

            this.extra.Text = "Extras";
        }

        private void inicioR_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime inicioContrato = DateTime.Parse(inicioR.Text);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                MessageBox.Show("{0}", ex.Message);
            }
        }

        private void fimR_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime inicioContrato = DateTime.Parse(fimR.Text);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                MessageBox.Show("{0}", ex.Message);
            }
        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }
    }
}
