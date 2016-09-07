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
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            FrmPrincipal Dueño = (FrmPrincipal)this.Owner;
            Dueño
        }

        public void ActualizarNombre(string nombre)
        {
            this.label1.Text = nombre;
        }
    }
}
