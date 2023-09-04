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
        private Auto auto=null; 
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Auto seleccionado)
        {
            InitializeComponent();
            this.auto = seleccionado;
            Text = "Modificar Auto";
          
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
                if (auto == null)
                
                auto = new Auto();
                auto.categoria =(Categoria) cboxModelo.SelectedItem;
                auto.marca = (Marca)cboxMarca.SelectedItem;
                auto.nombre = txtbNombre.Text;
                auto.precio = decimal.Parse(txtbPrecio.Text);
                auto.codigo = txtbCodigo.Text;
                auto.descripcion = txtbDescripcion.Text;
                auto.urlImagen = txtbUrl.Text;
                

                if (auto.Id != 0)
                {
                    autoNegocio.modificarAuto(auto);
                    MessageBox.Show("Modificado con Exito!");
                } else
                {
                autoNegocio.agregarAuto(auto);
                MessageBox.Show("Agregado Correctamente!");

                }



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
                cboxModelo.ValueMember = "id";//---->valor para hacer referencia
                cboxModelo.DisplayMember = "descripcion"; //lo que muestro
                cboxModelo.DataSource = negocioCategoria.ListarCategorias();
                cboxMarca.ValueMember = "id";//---->valor para hacer referencia
                cboxMarca.DisplayMember = "descripcion"; //lo que muestro
                cboxMarca.DataSource = negocioMarca.listarMarcas();
                if (auto != null)
                {
                    txtbCodigo.Text = auto.codigo;
                    txtbDescripcion.Text = auto.descripcion;
                    txtbNombre.Text = auto.nombre;
                    txtbPrecio.Text = auto.precio.ToString();
                    txtbUrl.Text = auto.urlImagen;
                    cboxMarca.SelectedValue = auto.marca.id;
                    cboxModelo.SelectedValue = auto.categoria.id;

                }

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

        private void txtbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancela la entrada
                e.Handled = true;
            }
        }
    }
}
