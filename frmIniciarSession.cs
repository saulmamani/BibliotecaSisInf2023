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
    public partial class FrmIniciarSession : Form
    {
        public FrmIniciarSession()
        {
            InitializeComponent();
        }

        private void btnInicar_Click(object sender, EventArgs e)
        {
            string cuenta = txtCuenta.Text;
            string password = txtPassword.Text;

            if (cuenta == "admin" && password == "123456")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
            }
            else
                MessageBox.Show("Error! Cuenta o Password incorrectos");
        }
    }
}
