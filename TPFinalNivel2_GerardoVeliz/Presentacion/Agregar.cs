using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using Presentacion;

namespace Presentacion
{
        
    public partial class frmAgregar : Form
    {
        private Auto auto; 
        public frmAgregar()
        {
            InitializeComponent();
          
        }

        private void cargarImagen(string imagen)

        {
            try
            {
                pboxUrl.Load(imagen);

            }
            catch (Exception)
            {

                pboxUrl.Load("https://th.bing.com/th/id/OIP.CnjIih4IXLpoe5vD54ybJQHaHa?pid=ImgDet&rs=1");
            }


        }



        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

            autoNegocio autoNegocio = new autoNegocio();
            try
            {
                auto = new Auto();
                auto.categoria =(Categoria) cboxModelo.SelectedItem;
                auto.marca = (Marca)cboxMarca.SelectedItem;
                auto.nombre = txtbNombre.Text;
                auto.precio = decimal.Parse(txtbPrecio.Text);
                auto.codigo = txtbCodigo.Text;
                auto.descripcion = txtbDescripcion.Text;
                auto.urlImagen = txtbUrl.Text;
                autoNegocio.agregarAuto(auto);
                MessageBox.Show("Agregado Correctamente!");


                this.Close();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbUrl_TextChanged(object sender, EventArgs e)
        {
            string url = txtbUrl.Text;
            cargarImagen(url);
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            marcaNegocio negocioMarca = new marcaNegocio();
            categoriaNegocio negocioCategoria = new categoriaNegocio();
            try
            {
                cboxModelo.DataSource = negocioCategoria.ListarCategorias();
                cboxMarca.DataSource = negocioMarca.listarMarcas();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
