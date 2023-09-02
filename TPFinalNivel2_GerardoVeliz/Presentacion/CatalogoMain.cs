using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmCatalogoMain : Form
    {
        private List<Auto> listaAuto;
        public frmCatalogoMain()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            autoNegocio autoNegocios = new autoNegocio(); 
            try
            {
                listaAuto = autoNegocios.listarAutos();
                dgvCatalogo.DataSource = listaAuto;
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }

        }
      

        private void frmCatalogoMain_Load(object sender, EventArgs e)
        {
            try
            {

            cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCatalogoMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Cierra la aplicación por completo
            }
        }

        private void pboxImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
