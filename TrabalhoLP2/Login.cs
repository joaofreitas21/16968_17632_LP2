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
    public partial class Login : Form
    {
        //utilizamos threads porque é das maneiras mais corretas, pois assim o programa corre uma so vez, inicializa e fecha quando recebe a ordem
        //definir thread para ligar os forms entre si
        Thread t1;

        public Login()
        {
            InitializeComponent();
        }

        //defenir funçoes para o button
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrir_menu);
            t1.TrySetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        //metodo para abrir o proximo form que desejamos
        private void abrir_menu(object obj)
        {
            Application.Run(new Menu());
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
