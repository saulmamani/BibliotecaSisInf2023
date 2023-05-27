using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSisInf
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buscarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmBuscarMaterial = new Form1();

            frmBuscarMaterial.MdiParent = this;
            frmBuscarMaterial.WindowState = FormWindowState.Maximized;
            frmBuscarMaterial.Show();
        }
    }
}
