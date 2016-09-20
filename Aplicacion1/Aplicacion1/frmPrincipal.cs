using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion1
{
    public delegate void unDelegado(string cadena);

    public partial class frmPrincipal : Form
    {
        public unDelegado miDelegado;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestDelegados FormDelegados = new FrmTestDelegados();

            // COMO LO MUESTRO CENTRADO????? DESDE ACA...-----------------------------------------------------------------------------------------

            FormDelegados.Show(this);
                       
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos Datos = new FrmDatos();
            Datos.MdiParent = this;
            Datos.Show();

        }
    }
}
