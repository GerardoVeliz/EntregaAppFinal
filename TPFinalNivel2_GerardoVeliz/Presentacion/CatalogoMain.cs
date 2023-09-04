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
        private void ocultarColumnas()
        {
            dgvCatalogo.Columns["UrlImagen"].Visible = false;
            dgvCatalogo.Columns["Id"].Visible = false;
        }

        private void cargar()
        {
            autoNegocio autoNegocios = new autoNegocio(); 
            try
            {
                listaAuto = autoNegocios.listarAutos();
                dgvCatalogo.DataSource = listaAuto;
                ocultarColumnas();
               
                


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
                cboxCampo.Items.Add("...");
                cboxCampo.Items.Add("Nombre");
                cboxCampo.Items.Add("Codigo");
                cboxCampo.Items.Add("Descripcion");
                cboxCampo.Items.Add("Precio");

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
                if (dgvCatalogo.CurrentRow != null)
            {
                Auto aux = (Auto)dgvCatalogo.CurrentRow.DataBoundItem;
                cargarImagen(aux.urlImagen);
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

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            string filtro;
            List<Auto> listaFiltrada = new List<Auto>();
                filtro = txtbFiltroRapido.Text;
            try
            {
                if (filtro != "")
                {
                listaFiltrada = listaAuto.FindAll(x => x.codigo.ToUpper().Contains(filtro.ToUpper()) ||x.nombre.ToUpper().Contains(filtro.ToUpper())||x.descripcion.ToUpper().Contains(filtro.ToUpper()) || x.categoria.descripcion.ToUpper().Contains(filtro.ToUpper()) );

                }
                else
                {
                    listaFiltrada = listaAuto; 
                }
                dgvCatalogo.DataSource = null;
                dgvCatalogo.DataSource = listaFiltrada;
                ocultarColumnas(); 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }

        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            autoNegocio negocioAuto = new autoNegocio();
            cboxCriterio1.Items.Clear();
            string campoSeleccionado;
            try
            {
                campoSeleccionado = cboxCampo.SelectedItem.ToString();
                if (campoSeleccionado == "Precio")
                {
                    cboxCriterio1.Items.Add("Mayor a");
                    cboxCriterio1.Items.Add("Menor a");
                    cboxCriterio1.Items.Add("Igual a");

                } 
                else if (campoSeleccionado== "...")
                {
                    cboxCriterio1.Items.Clear();
                    dgvCatalogo.DataSource = negocioAuto.listarAutos();
                }
                else 
                {
                    cboxCriterio1.Items.Add("Comienza con");
                    cboxCriterio1.Items.Add("Termina con");
                    cboxCriterio1.Items.Add("Contiene ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }
        private bool SoloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))

                    return false;
            }
            return true;
        }
        public bool validaciones()
        {
            if (cboxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por Favor elija un valor en el desplegable Campo, primero..");
                return false;
            }
            if (cboxCriterio1.SelectedIndex < 0)
            {
                MessageBox.Show("Por Favor elija un valor en el desplegable criterio, primero..");
                return false;
            }
            if (cboxCampo.SelectedItem.ToString() == "Numero")
            {

                if (string.IsNullOrEmpty(txtboxCriterio.Text))
                {
                    MessageBox.Show("Por favor complete este el campo Filtro, primero... ");
                    return false;
                }


                if (!(SoloNumeros(txtboxCriterio.Text)))
                {
                    MessageBox.Show("Este Campo solo tiene que tener numeros..");
                    return false;
                }

            }
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            autoNegocio negocioAuto= new autoNegocio(); 
            try
            {
                if (!(validaciones()))
                    return;

                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio1.SelectedItem.ToString();
                string filtro = txtboxCriterio.Text;
                dgvCatalogo.DataSource = negocioAuto.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
