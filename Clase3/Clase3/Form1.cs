using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase3
{
    public delegate void delegadoString(string cadena); //el "nombre" del delegado es la firma de metodos que puede implementar, por ejemplo el noombre seria = "void delegadostring(string cadena)"
    //el delegado es como una clase, un tipo mas de objeto
    
    public partial class FrmPrincipal : Form
    {
        public delegadoString nombreDelObjetoTipoDelegadoString;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrigen frmesorigen = new FrmOrigen();
            // Set the Parent Form of the Child window.
            frmesorigen.MdiParent = this;
            // Display the new form.
            frmesorigen.Show();
        }

        private void destinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDestino frmesdestino = new FrmDestino();

            frmesdestino.Show(this);
        }
    }
}
