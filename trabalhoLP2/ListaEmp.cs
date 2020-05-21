using BL;
using BO;
using System;
using System.Threading;
using System.Windows.Forms;

namespace TrabalhoLP2
{
    public partial class ListaEmp : Form
    {
        Thread m1;
        public ListaEmp()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            m1 = new Thread(volta_Menu);
            m1.TrySetApartmentState(ApartmentState.STA);
            m1.Start();
        }

        private void ListaEmp_Load(object sender, EventArgs e)
        {
            
        }
       

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void volta_Menu(object obj)
        {
            Application.Run(new Menu());
        }



        private void codE_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empregado emp = new Empregado();
            if (codE.Text.Length != 0 && codH.Text.Length != 0)
            {
                ControlaEmpregados.GetEmpregado(Int32.Parse(codE.Text), Int32.Parse(codH.Text));
                if (Int32.Parse(codE.Text) == emp.IDEmpregado)
                {
                    dataGridView1.DataSource = ControlaEmpregados.RegistoEmpregado(Int32.Parse(codE.Text), Int32.Parse(codH.Text));
                }
                else
                {
                    MessageBox.Show("Empregado não existe!");
                }

            }
            else
            {
                MessageBox.Show("Campos por preencher!!!");
            }
        }
    }
}

