using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        ProductoDA productoDA = new ProductoDA();
        Pedido Pedido = new Pedido();
        Producto producto;
        //FacturaDA facturaDA = new FacturaDA();


        List<DetallePedido> DetallePedidoslista = new List<DetallePedido>();

        decimal subTotal = decimal.Zero;
        decimal isv = decimal.Zero;
        decimal totalAPagar = decimal.Zero;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            DetalledataGridView.DataSource = DetallePedidoslista;
        }

        private void CodigoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoDA.GetProductoPorCodigo(CodigoTextBox.Text);
                DescripcionTextBox.Text = producto.Descripcion;
                CantidadTextBox.Focus();
            }
            else
            {
                producto = null;
                DescripcionTextBox.Clear();
                CantidadTextBox.Clear();
            }
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadTextBox.Text))
            {

                DetallePedido detallePedido = new DetallePedido();
                detallePedido.CodigoProducto = producto.Codigo;
                detallePedido.Descripcion = producto.Descripcion;
                detallePedido.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                detallePedido.Precio = producto.Precio;
                detallePedido.Total = producto.Precio * Convert.ToInt32(CantidadTextBox.Text);

                subTotal += detallePedido.Total;
                isv = subTotal * 0.15M;
                totalAPagar = subTotal + isv;

                SubTotalTextBox.Text = subTotal.ToString();
                ISVTextBox.Text = isv.ToString();
                TotalTextBox.Text = totalAPagar.ToString();

                DetallePedidoslista.Add(detallePedido);
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = DetallePedidoslista;
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
