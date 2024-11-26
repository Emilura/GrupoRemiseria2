using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Remiseria.Vistas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente ventana= new frmCliente();
            ventana.MdiParent= this;
            ventana.Show();

        }

        private void choferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChofer ventana=new frmChofer();
            ventana.MdiParent= this;
            ventana.Show();
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicio ventana=new frmServicio();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculo ventana = new frmVehiculo();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
