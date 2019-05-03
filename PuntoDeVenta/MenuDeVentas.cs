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
    public partial class frmMenuDeVentas : Form
    {
        Form Owner = new Login();
        public frmMenuDeVentas(Login parent)
        {
            InitializeComponent();
            this.Owner = parent;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoProducto objForm = new frmIngresoProducto();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoProducto objForm = new frmIngresoProducto();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void frmMenuDeVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                this.Owner.Close();
        }

        private void frmMenuDeVentas_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuDeVentas_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                this.Owner.Close();
        }
    }
}
