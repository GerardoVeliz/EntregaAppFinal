using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPantallaBienvenida : Form
    {
        public FrmPantallaBienvenida()
        {
            InitializeComponent();
        }


        private void FrmPantallaBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void btnMagia_Click(object sender, EventArgs e)
        {
            
                this.Hide(); // Ocultar el primer formulario

                frmCatalogoMain formSecundario = new frmCatalogoMain();
                formSecundario.FormClosed += (s, args) => { this.Close(); };
                formSecundario.Show();
            }

        
    }
}
