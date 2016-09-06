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
    public partial class FrmOrigen : Form
    {
        public FrmOrigen()
        {
            InitializeComponent();
        }

        private void FrmOrigen_Load(object sender, EventArgs e)
        {
           
            
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmPrincipal Padre = (FrmPrincipal)this.MdiParent;
            if (Padre.nombreDelObjetoTipoDelegadoString != null)
            {
                //
                Padre.nombreDelObjetoTipoDelegadoString(this.txtMensaje.Text);
            }
        }
    }
}
