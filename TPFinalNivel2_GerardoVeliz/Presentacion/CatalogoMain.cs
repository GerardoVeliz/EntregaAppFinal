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
                dgvCatalogo.Columns["UrlImagen"].Visible = false;
                dgvCatalogo.Columns["Id"].Visible = false; 
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }

        }

        private void cargarImagen(string imagen)

        {
            try
            {
            pboxImagen.Load(imagen);

            }
            catch (Exception)
            {

                pboxImagen.Load("https://th.bing.com/th/id/OIP.CnjIih4IXLpoe5vD54ybJQHaHa?pid=ImgDet&rs=1");
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

        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Auto aux = new Auto();
                aux = (Auto)dgvCatalogo.CurrentRow.DataBoundItem;
                cargarImagen(aux.urlImagen);
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregarAuto = new frmAgregar();
            frmAgregarAuto.ShowDialog();
            cargar();
        }

        private void nuevoElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregarAuto = new frmAgregar();
            frmAgregarAuto.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Auto selecionado = new Auto();
            selecionado = (Auto)dgvCatalogo.CurrentRow.DataBoundItem;
            frmAgregar frmModificarAuto = new frmAgregar(selecionado);
            frmModificarAuto.ShowDialog();
            cargar();

        }

        private void btnBajaFisica_Click(object sender, EventArgs e)
        {
            autoNegocio negocioAuto = new autoNegocio();
            Auto seleccionado = new Auto();

            try
            {
                
                DialogResult respuesta= MessageBox.Show("Esta seguro que quiere elimnar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                seleccionado = (Auto)dgvCatalogo.CurrentRow.DataBoundItem;
                negocioAuto.bajaFisica(seleccionado.Id);
                MessageBox.Show("Eliminado con exito!"); 
                cargar();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }

        private void panel1_DockChanged(object sender, EventArgs e)
        {
            if (panelLateral.Width == 0)
            {
                // Mostrar el panel lateral
                panelLateral.Width = 200; // Define el ancho que desees
            }
            else
            {
                // Ocultar el panel lateral
                panelLateral.Width = 0;
            }
        }
    }
}
