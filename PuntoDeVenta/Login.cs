using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Entity.Login user = new Entity.Login();
            user.User = txtUser.Text;
            user.Password = txtPassword.Text;

            if(user.User == user.Password)
            {
                frmMenuDeVentas frmVenta = new frmMenuDeVentas(this);
                frmVenta.Show();
                this.Hide();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
