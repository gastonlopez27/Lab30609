using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace Aplicacion1
{
    public partial class FrmTestDelegados : Form
    {
        private string __ruta;

        public FrmTestDelegados()
        {
            InitializeComponent();

            this.openFileDialog1.InitialDirectory = @"c:\imagenesPrueba\";
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmPrincipal Padre = (frmPrincipal)this.Owner;


            if(Padre.miDelegado != null)
            {
                Padre.miDelegado(txt.Text);
            }


      
        }

        //Nota: Se deberá utilizar un delegado, convenientemente diseñado, declarado en un módulo
        //y cuya variable asociada también resida en un módulo.

        //MODULO?

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            
            this.openFileDialog1.ShowDialog();
            this.__ruta = this.openFileDialog1.FileName;
         
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

      
    }
}
