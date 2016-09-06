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
    public partial class FrmDestino : Form
    {
        public FrmDestino()
        {
            InitializeComponent();
        }

        private void FrmDestino_Load(object sender, EventArgs e)
        {
            //tengo q castear al owner porque quiero acceder a un atributo de la clase
            //especifica frmPrincipal. Owner por defecto es clase Form
            //this.Owner.nombreDelObjetoTipoDelegadoString = this.mostrarMensaje;
            FrmPrincipal dueño = (FrmPrincipal)this.Owner;
            dueño.nombreDelObjetoTipoDelegadoString = this.mostrarMensaje;

            //Otra forma de hacerlo, 
            //((FrmPrincipal)this.Owner).nombreDelObjetoTipoDelegadoString = this.mostrarMensaje;

        }

        void mostrarMensaje(string mensaje)
        {
            this.lblMensaje.Text = mensaje;
        }
    }
}
