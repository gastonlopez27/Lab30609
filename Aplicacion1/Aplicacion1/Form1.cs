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
    public delegate void delegadoNombrar (string cadena);

    public partial class FrmPrincipal : Form
    {
        delegadoNombrar miDelegado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestDelegados frmDelegados = new FrmTestDelegados();
            frmDelegados.Show(this);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos Datos = new FrmDatos();
            Datos.Show(this);
        }
    }
}
