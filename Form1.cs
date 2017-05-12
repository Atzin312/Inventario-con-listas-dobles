using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Inventario
{
    public partial class Form1 : Form
    {
        Inventario inventario = new Inventario();
        Producto producto;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            if (inventario.buscarProducto(codigo) != null)
            {
                txtReporte.Text = inventario.buscarProducto(codigo).nombre;
            }
            else
            {
                txtReporte.Clear();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inventario.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inventario.eliminarProducto(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            inventario.agregarProducto(producto);
            txtCodigo.Focus();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            inventario.agregarInicio(producto);
            txtCodigo.Focus();
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            Producto producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            inventario.insertarProducto(producto, Convert.ToInt32(txtPocision.Text));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtReporte.Text = inventario.reporteInverso();
        }

        private void btnEliminarPrimerProducto_Click(object sender, EventArgs e)
        {
            inventario.eliminarPrimerProducto();
        }

        private void btnEliminarUltimoProducto_Click(object sender, EventArgs e)
        {
            inventario.eliminarUltimoProducto();
        }
    }
}
